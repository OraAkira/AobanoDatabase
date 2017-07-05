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
using System.Diagnostics;

namespace Aoba.v._0._1
{
    public partial class AdminForm : Form
    {
        private Basic.UserType usertype;
        private string tablename;

        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(bool trueadmin)
        {
            InitializeComponent();
            if(!trueadmin)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
                dataGridView1.Enabled = false;
            }
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM users";
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            Basic.mylink.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "users");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "users";
            usertype = Basic.UserType.user;
            tablename = "users";
            Basic.mylink.Close();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[1].Enabled = true;
            string SQL = "SELECT * FROM teacher";
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            Basic.mylink.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "teacher");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "teacher";
            usertype = Basic.UserType.teacher;
            tablename = "teacher";
            Basic.mylink.Close();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[1].Enabled = true;
            string SQL = "SELECT * FROM student";
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            Basic.mylink.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "student";
            usertype = Basic.UserType.student;
            tablename = "student";
            Basic.mylink.Close();
        }

        private void Courses_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[1].Enabled = false;
            string SQL = "SELECT course._Id, course._Name, teacher._Name, course._Time, course._Place FROM course, teacher WHERE course._Teacher = teacher._Id";
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            Basic.mylink.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "course");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "course";
            usertype = Basic.UserType.course;
            tablename = "course";
            Basic.mylink.Close();
        }

        private void Elective_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM elective";
            SqlCommand cmd = new SqlCommand(SQL, Basic.mylink);
            Basic.mylink.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "course");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "course";
            usertype = Basic.UserType.elective;
            tablename = "course";
            Basic.mylink.Close();
        }

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switch(usertype)
            {
                case Basic.UserType.user: Form user = new Form(); user.ShowDialog(); break;
                case Basic.UserType.teacher: TeacherForm teacher = new TeacherForm(); teacher.ShowDialog(); break;
                case Basic.UserType.student: StudentForm student = new StudentForm(); student.ShowDialog(); break;
                case Basic.UserType.course: CourseForm course = new CourseForm(); course.ShowDialog(); break;
                case Basic.UserType.elective: electiveForm elective = new electiveForm(); elective.ShowDialog(); break;
            }
            
        }

        private void 查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            QueryFrom query = new QueryFrom(usertype);
            query.ShowDialog();
            try
            {
                SqlCommand cmd = new SqlCommand(query.sql, Basic.mylink);
                Basic.mylink.Open();
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
                string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                switch (usertype)
                {
                    case Basic.UserType.user: Form user = new Form(); user.ShowDialog(); break;
                    case Basic.UserType.teacher: TeacherForm teacher = new TeacherForm(id); teacher.ShowDialog(); break;
                    case Basic.UserType.student: StudentForm student = new StudentForm(id); student.ShowDialog(); break;
                    case Basic.UserType.course: CourseForm course = new CourseForm(id); course.ShowDialog(); break;
                    case Basic.UserType.elective: electiveForm elective = new electiveForm(id); elective.ShowDialog(); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码：{0}" + ex.ToString());
            }
        }

        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["_Id"].Value.ToString();
                string sql = "DELETE FROM " + tablename + " WHERE _id=" + id;
                SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                Basic.mylink.Open();
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
                MessageBox.Show("错误代码：{0}" + ex.ToString());
            }
            finally
            {
                Basic.mylink.Close();
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", ".\\Help.txt");
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.1.20170704_beta\nAuthor: Ameya\nDataBase: SQL Server2016\nDataSourse: 123.206.218.134");
        }
    }
}
