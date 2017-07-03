using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Aoba.v._0._1
{
    public partial class CourseForm : Form
    {

        private bool modify = false;
        private string id;

        public CourseForm()
        {
            InitializeComponent();
        }
        public CourseForm(string _id)
        {
            modify = true;
            InitializeComponent();
            id = _id;
            string sql = "SELECT course.*, teacher._Name as Tname FROM course, teacher WHERE course._Teacher = teacher._Id AND course._Id=" + _id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            Basic.mylink.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["_Name"].ToString();
                    textBox2.Text = reader["Tname"].ToString();
                    textBox3.Text = reader["_Time"].ToString();
                    textBox4.Text = reader["_Place"].ToString();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("错误代码：{0}", e);
            }
            finally
            {
                Basic.mylink.Close();
                modify = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = null;
            if (modify)
            {
                sql = "UPDATE course SET _Name='" + textBox1.Text + "', _Teacher='" + Link2Teacher(textBox2.Text) + "',_Time='" + textBox3.Text + "',_Place=" + textBox4.Text + "WHERE  _Id=" + id;
            }
            else
            {
                sql = "INSERT INTO course (_Name, _Teacher, _Time, _Place) VALUES('"
                        + textBox1.Text + "', " + Link2Teacher(textBox2.Text) + ", '" + textBox3.Text + "', " + textBox4.Text + ")";
            }
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            Basic.mylink.Open();
            try
            {
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("插入成功！");
                }
                else
                {
                    MessageBox.Show("插入失败...");
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
        }

        private string Link2Teacher(string text)
        {
            string result;
            Basic.mylink.Open();
            string sql = "SELECT _Id FROM teacher WHERE _Name='" + text + "'";
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = reader["_Id"].ToString();
            }
            else
            {

                result = null;
            }
            Basic.mylink.Close();
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
