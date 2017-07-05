using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace Aoba.v._0._1
{
    public partial class TeacherForm : Form
    {
        private bool modify = false;
        private string id;

        public TeacherForm()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
        }

        public TeacherForm(string _id)
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            modify = true;
            id = _id;
            string sql = "SELECT * FROM teacher WHERE _Id=" + _id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if(datareader.Read())
                {
                    textBox3.Text = datareader["_Id"].ToString();
                    textBox1.Text = datareader["_Name"].ToString();
                    textBox2.Text = datareader["_Old"].ToString();
                    textBox5.Text = datareader["_Link"].ToString();
                    textBox4.Text = datareader["_Remark"].ToString();
                    comboBox1.SelectedIndex = GetComboIndex(comboBox1, datareader["_Sex"].ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("错误代码：{0}", e);
                MessageBox.Show("未能执行此命令");
                this.Close();
            }
            finally
            {
                Basic.mylink.Close();
            }
            if(modify)
            {
                cmd.Dispose();
                sql = "SELECT * FROM course WHERE _Teacher=" + _id;
                cmd = new SqlCommand(sql, Basic.mylink);
                try
                {
                    Basic.mylink.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "course");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "course";
                    Basic.mylink.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("错误代码：" + e.ToString());
                }
                finally
                {
                    Basic.mylink.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(modify)
            {
                string sql = "UPDATE teacher SET _Name='" + textBox1.Text + "', _Link='" + textBox5.Text + "', _Remark='" + textBox4.Text + "'" +
                    ", _Old=" + textBox2.Text + ", _Sex='" + comboBox1.SelectedItem.ToString() + "'\nWHERE _id=" + id;
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                try
                {
                    Basic.mylink.Open();
                    if (1 == cmd.ExecuteNonQuery())
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败...");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.ToString());
                }
                finally
                {
                    Basic.mylink.Close();
                }
                this.Close();
            }
            else
            {
                if (textBox2.Text == String.Empty)
                    textBox2.Text = "20";
                string sql = "INSERT INTO teacher (_Name, _Sex, _Old, _Link, _Remark) VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', " + textBox2.Text + ",'" + textBox5.Text + "','" + textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                Basic.mylink.Open();
                try
                {
                    if (1 == cmd.ExecuteNonQuery())
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败...");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.ToString());
                }
                finally
                {
                    Basic.mylink.Close();
                }
                string sqlstr = "SELECT _Id FROM teacher WHERE _Name='" + textBox1.Text + "' AND _Link='" + textBox5.Text + "'";
                string Id = null;
                string pwd = Basic.InputBox();
                SqlCommand tmpcmd = new SqlCommand(sqlstr, Basic.mylink);
                Basic.mylink.Open();
                try
                {
                    SqlDataReader reader = tmpcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Id = reader["_Id"].ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.ToString());
                }
                finally
                {
                    Basic.mylink.Close();
                }
                Basic.adduser(Id, pwd, "Teacher", "select update");
                this.Close();
            }
            
        }

        private int GetComboIndex(ComboBox mylist, string text)
        {
            text = Regex.Replace(text, @"\s", "");
            foreach (object tmp in mylist.Items)
            {
                if (text == tmp.ToString())
                {
                    return mylist.Items.IndexOf(tmp);
                }

            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idCou = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            ClassForm classroom = new ClassForm(idCou);
            classroom.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
