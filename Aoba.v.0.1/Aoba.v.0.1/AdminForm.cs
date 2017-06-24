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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM teacher";
            Basic.mylink.Open();
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "teacher");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "teacher";
            Basic.mylink.Close();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM student";
            Basic.mylink.Open();
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "student";
            Basic.mylink.Close();
        }
        
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.ShowDialog();
        }

        private void 查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            QueryFrom query = new QueryFrom(3);
            query.ShowDialog();
            Basic.mylink.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query.sql, Basic.mylink);
                SqlDataReader datareader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(datareader);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("无该记录，请确认查询条件没有错误");
                Console.WriteLine("错误代码：{0}", ex);
            }
            finally
            {
                Basic.mylink.Close();
            }
        }

        private void 修改ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["_Id"].Value.ToString();
                TeacherForm teacher = new TeacherForm(id);
                teacher.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未选中任何有效行");
                Console.WriteLine("错误代码：{0}", ex);
            }
            finally
            {
                
            }
        }

        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["_Id"].Value.ToString();
                string sql = "DELETE FROM teacher WHERE _id=" + id;
                Basic.mylink.Open();
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("未选中任何有效行");
                Console.WriteLine("错误代码：{0}", ex);
            }
            finally
            {
                Basic.mylink.Close();
            }
        }
    }
}
