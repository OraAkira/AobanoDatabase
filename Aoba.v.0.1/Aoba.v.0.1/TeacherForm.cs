using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aoba.v._0._1
{
    public partial class TeacherForm : Form
    {
        private bool modify = false;
        private string id;
        public TeacherForm()
        {
            InitializeComponent();
        }

        public TeacherForm(string _id)
        {
            InitializeComponent();
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
                    textBox1.Text = datareader["_Id"].ToString();
                    textBox2.Text = datareader["_Name"].ToString();
                    textBox3.Text = datareader["_Link"].ToString();
                    textBox4.Text = datareader["_Remark"].ToString();
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(modify)
            {
                string sql = "UPDATE teacher SET _Name='" + textBox2.Text + "', _Link='" + textBox3.Text + "', _Remark='" + textBox4.Text + "'\nWHERE _id=" + id;
                Basic.mylink.Open();
                MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败...");
                }
                Basic.mylink.Close();
                this.Close();
            }
            else
            {
                string sql = "INSERT INTO teacher (_Name, _Link, _Remark) VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')";
                Basic.mylink.Open();
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败...");
                }
                Basic.mylink.Close();
                this.Close();
            }
            
        }
    }
}
