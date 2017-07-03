using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace Aoba.v._0._1
{
    public partial class StudentForm : Form
    {
        private string id;
        private bool modify = false;

        public StudentForm()
        {
            InitializeComponent();
            SetDefaultText();
            ReadOnly();
        }

        public StudentForm(string _id)
        {
            InitializeComponent();
            ReadOnly();
            id = _id;
            modify = true;
            string sql = "SELECT student.*, teacher._Name AS tName  from student, teacher WHERE teacher._Id = student._Teacher AND student._Id=" + _id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    textBox1.Text = datareader["_Name"].ToString();
                    comboBox1.SelectedIndex = GetComboIndex(comboBox1, datareader["_Sex"].ToString());
                    textBox3.Text = datareader["_Birth"].ToString();
                    textBox4.Text = datareader["_Id"].ToString();
                    textBox5.Text = datareader["_Nation"].ToString();
                    comboBox3.SelectedIndex = GetComboIndex(comboBox3, datareader["_Payment"].ToString());
                    textBox7.Text = datareader["_Link"].ToString();
                    textBox8.Text = datareader["tName"].ToString();
                    comboBox2.SelectedIndex =GetComboIndex(comboBox2, datareader["_Grade"].ToString());
                    textBox10.Text = datareader["_Address"].ToString();
                    textBox11.Text = datareader["_Organization"].ToString();
                    textBox12.Text = datareader["_Campus"].ToString();
                    textBox13.Text = datareader["_Absenteeism"].ToString();
                    textBox14.Text = datareader["_Late"].ToString();
                    textBox15.Text = datareader["_Homework"].ToString();
                    textBox16.Text = datareader["_Discipline"].ToString();
                    comboBox4.SelectedIndex = GetComboIndex(comboBox4, datareader["_ClassPerform"].ToString());
                    comboBox5.SelectedIndex = GetComboIndex(comboBox5, datareader["_StudyPerform"].ToString());
                    comboBox6.SelectedIndex = GetComboIndex(comboBox6, datareader["_Attitude"].ToString());
                    textBox20.Text = datareader["_Overall"].ToString();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("错误代码：{0}" + e.ToString());
                this.Close();
            }
            finally
            {
                Basic.mylink.Close();
            }
            cmd.Dispose();
            sql = "SELECT * FROM elective WHERE _IdStu=" + _id;
            cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "course");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "course";
            }
            catch (SqlException e)
            {
                MessageBox.Show("错误代码：{0}" + e.ToString());
                this.Close();
            }
            finally
            {
                Basic.mylink.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            if (modify)
            {
                sql = "UPDATE student SET "
                    + " _Name='" + textBox1.Text + "'"
                    + ", _Sex='" + comboBox1.SelectedItem.ToString() + "'"
                    + ", _Birth='" + textBox3.Text + "'"
                    + ", _Nation='" + textBox5.Text + "'"
                    + ", _Payment='" + comboBox3.SelectedItem.ToString() + "'"
                    + ", _Link='" + textBox7.Text + "'"
                    + ", _Teacher=" + Link2Teacher(textBox8.Text) + ""
                    + ", _Grade='" + comboBox2.SelectedItem.ToString() + "'"
                    + ", _Address='" + textBox10.Text + "'"
                    + ", _Organization='" + textBox11.Text + "'"
                    + ", _Campus='" + textBox12.Text + "'"
                    + ", _Absenteeism=" + textBox13.Text
                    + ", _Late=" + textBox14.Text
                    + ", _Homework=" + textBox15.Text
                    + ", _Discipline=" + textBox16.Text
                    + ", _ClassPerform='" + comboBox4.SelectedItem.ToString() + "'"
                    + ", _StudyPerform='" + comboBox5.SelectedItem.ToString() + "'"
                    + ", _Attitude='" + comboBox6.SelectedItem.ToString() + "'"
                    + ", _Overall='" + textBox20.Text + "'\n"
                    + " WHERE _Id=" + id;
            }
            else
            {
                sql = "INSERT INTO student (_Name, _Sex, _Birth, _Nation, " +
                    "_Payment, _Link, _Teacher, _Grade, _Address, _Organization, " +
                    "_Campus,  _Absenteeism, _Late, _Homework, _Discipline, " +
                    "_ClassPerform, _StudyPerform, _Attitude, _Overall) VALUES ('" +
                    textBox1.Text + "', '" + comboBox1.SelectedItem.ToString() + "', '" + textBox3.Text + "', '" +
                    textBox5.Text + "', '" + comboBox3.SelectedItem.ToString() + "', '" +
                    textBox7.Text + "', " + Link2Teacher(textBox8.Text) + ", '" + comboBox2.SelectedItem.ToString() + "', '" +
                    textBox10.Text + "', '" + textBox11.Text + "', '" + textBox12.Text + "', " +
                    textBox13.Text + ", " + textBox14.Text + ", " + textBox15.Text + ", " + textBox16.Text + ", '" +
                    comboBox4.SelectedItem.ToString() + "', '" + comboBox5.SelectedItem.ToString() + "', '" +
                    comboBox6.SelectedItem.ToString() + "', '" + textBox20.Text + "')";
            }
            MessageBox.Show(sql);
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
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
        }

        private void SetDefaultText()
        {
            comboBox1.SelectedIndex = 0;
            textBox3.Text = "2000-01-01";
            textBox3.ForeColor = Color.Gray;
            textBox5.Text = "汉";
            textBox5.ForeColor = Color.Gray;
            comboBox3.SelectedIndex = 0;
            textBox7.Text = "+86***********";
            textBox7.ForeColor = Color.Gray;
            textBox8.Text = "格日日哈";
            textBox8.ForeColor = Color.Gray;
            comboBox2.SelectedIndex = 9;
            textBox10.Text = "四川成都";
            textBox10.ForeColor = Color.Gray;
            textBox11.Text = "比丽弗教育机构";
            textBox11.ForeColor = Color.Gray;
            textBox12.Text = "普格";
            textBox12.ForeColor = Color.Gray;
            textBox13.Text = "0";
            textBox14.ForeColor = Color.Gray;
            textBox14.Text = "0";
            textBox15.ForeColor = Color.Gray;
            textBox15.Text = "0";
            textBox16.ForeColor = Color.Gray;
            textBox16.Text = "0";
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            textBox20.Text = "无说明";
            textBox1.ForeColor = Color.Gray;
        }

        private int GetComboIndex(ComboBox mylist, string text)
        {
            text = Regex.Replace(text, @"\s", "");
            foreach(object tmp in mylist.Items)
            {
                if (text == tmp.ToString())
                {
                    return mylist.Items.IndexOf(tmp);
                }
                    
            }
            return -1;
        }

        private string Link2Teacher(string text)
        {
            Basic.mylink.Open();
            string sql = "SELECT _Id FROM teacher WHERE _Name='" + text + "'";
            string result = null;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader["_Id"].ToString();
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
            return result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            electiveForm elective = new electiveForm(id);
            elective.ShowDialog();
        }

        private void ReadOnly()
        {
            textBox4.ReadOnly = true;
            textBox4.BackColor = Color.Gray;
            textBox13.ReadOnly = true;
            textBox13.BackColor = Color.Gray;
            textBox14.ReadOnly = true;
            textBox14.BackColor = Color.Gray;
            textBox15.ReadOnly = true;
            textBox15.BackColor = Color.Gray;
            textBox16.ReadOnly = true;
            textBox16.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(textBox13.Text);
            cnt++;
            textBox13.Text = cnt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(textBox14.Text);
            cnt++;
            textBox14.Text = cnt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(textBox15.Text);
            cnt++;
            textBox15.Text = cnt.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(textBox16.Text);
            cnt++;
            textBox16.Text = cnt.ToString();
        }
    }
}
