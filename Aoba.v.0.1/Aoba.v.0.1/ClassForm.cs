using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aoba.v._0._1
{
    public partial class ClassForm : Form
    {
        private string id;
        SqlDataAdapter adapter;

        public ClassForm(string _id)
        {
            InitializeComponent();
            id = _id;
            init(_id);
            studentshow(_id);
        }

        private void init(string id)
        {
            string sql = "SELECT * FROM course WHERE _id=" + id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox3.Text = reader["_Id"].ToString();
                    textBox4.Text = reader["_Name"].ToString();
                    textBox5.Text = reader["_Teacher"].ToString();
                    textBox6.Text = reader["_Time"].ToString();
                    textBox7.Text = reader["_Place"].ToString();
                }
                Basic.mylink.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("错误代码：" + e.ToString());
            }
        }

        private void studentshow(string id)
        {
            string sql = "SELECT * FROM elective WHERE _IdCou=" + id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                Basic.mylink.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("错误代码：" + e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idstu = GetIdStu();
            string sql = "SELECT * FROM elective WHERE _IdStu=" + idstu + " AND _IdCou=" + id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(datareader);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码：" + ex.ToString());
            }
            finally
            {
                Basic.mylink.Close();
            }
        }

        private string GetIdStu()
        {
            string result = null;
            if (textBox2.Text != "")
                result = textBox2.Text;
            else
            {
                string sql = "SELECT _Id FROM student WHERE _Name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                try
                {
                    Basic.mylink.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                        result = reader["_Id"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误代码：" + ex.ToString());
                }
                finally
                {
                    Basic.mylink.Close();
                }
            }
            return result;
        }

        private DataTable dbconn(string strSql)
        {
            Basic.mylink.Open();
            this.adapter = new SqlDataAdapter(strSql, Basic.mylink);
            DataTable dtSelect = new DataTable();
            int rnt = adapter.Fill(dtSelect);
            Basic.mylink.Close();
            return dtSelect;
        }

        private Boolean dbUpdate()
        {
            string strSql = "select* from elective";
            DataTable dtUpdate = new DataTable();
            dtUpdate = dbconn(strSql);
            dtUpdate.Rows.Clear();
            DataTable dtShow = new DataTable();
            dtShow = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                dtUpdate.ImportRow(dtShow.Rows[i]);
            }
            try
            {
                Basic.mylink.Open();
                SqlCommandBuilder CommandBuiler;
                CommandBuiler = new SqlCommandBuilder(adapter);
                adapter.Update(dtUpdate);
                Basic.mylink.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            dtUpdate.AcceptChanges();
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dbUpdate())
            {
                MessageBox.Show("修改成功！");
            }
        }
    }
}
