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
    public partial class StudentForm : Form
    {
        private string id;
        private bool modify = false;

        public StudentForm()
        {
            InitializeComponent();
            SetDefaultText();
        }

        public StudentForm(string _id)
        {
            InitializeComponent();
            id = _id;
            modify = true;
            string sql = "SELECT * FROM student WHERE _Id=" + _id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    textBox1.Text = datareader["_Name"].ToString();
                    textBox2.Text = datareader["_Sex"].ToString();
                    textBox3.Text = datareader["_Birth"].ToString();
                    textBox4.Text = datareader["_Id"].ToString();
                    textBox5.Text = datareader["_Nation"].ToString();
                    textBox6.Text = datareader["_Payment"].ToString();
                    textBox7.Text = datareader["_Link"].ToString();
                    textBox8.Text = datareader["_Teacher"].ToString();
                    textBox9.Text = datareader["_Grade"].ToString();
                    textBox10.Text = datareader["_Address"].ToString();
                    textBox11.Text = datareader["_Organization"].ToString();
                    textBox12.Text = datareader["_Campus"].ToString();
                    textBox13.Text = datareader["_Absenteeism"].ToString();
                    textBox14.Text = datareader["_Late"].ToString();
                    textBox15.Text = datareader["_Homework"].ToString();
                    textBox16.Text = datareader["_Discipline"].ToString();
                    textBox17.Text = datareader["_ClassPerform"].ToString();
                    textBox18.Text = datareader["_StudyPerform"].ToString();
                    textBox19.Text = datareader["_Attitude"].ToString();
                    textBox20.Text = datareader["_Overall"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("错误代码：{0}", e);
                MessageBox.Show("未能执行此命令");
                this.Close();
            }
            finally
            {
                Basic.mylink.Close();
            }
            cmd.Dispose();
            sql = "SELECT * FROM elective WHERE _StdId=" + _id;
            cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
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
            string sql;
            if (modify)
            {
                sql = "UPDATE teacher SET "
                    + " _Name='" + textBox1.Text + "'"
                    + ", _Sex='" + textBox2.Text + "'"
                    + ", _Birth='" + textBox3.Text + "'"
                    + ", _Id=" + textBox4.Text
                    + ", _Nation='" + textBox5.Text + "'"
                    + ", _Payment='" + textBox6.Text + "'"
                    + ", _Link='" + textBox7.Text + "'"
                    + ", _Teacher=" + textBox8.Text + ""
                    + ", _Grade='" + textBox9.Text + "'"
                    + ", _Address='" + textBox10.Text + "'"
                    + ", _Organization='" + textBox11.Text + "'"
                    + ", _Campus='" + textBox12.Text + "'"
                    + ", _Absenteeism=" + textBox13.Text
                    + ", _Late=" + textBox14.Text
                    + ", _Homework=" + textBox15.Text
                    + ", _Discipline=" + textBox16.Text
                    + ", _ClassPerform='" + textBox17.Text + "'"
                    + ", _StudyPerform='" + textBox18.Text + "'"
                    + ", _Attitude='" + textBox19.Text + "'"
                    + ", _Overall='" + textBox20.Text + "'\n"
                    + " WEHER _Id = " + id;
            }
            else
            {
                sql = "INSERT INTO student (_Name, _Sex, _Birth, _Nation, " +
                    "_Payment, _Link, _Teacher, _Grade, _Address, _Organization, " +
                    "_Campus,  _Absenteeism, _Late, _Homework, _Discipline, " +
                    "_ClassPerform, _StudyPerform, _Attitude, _Overall) VALUES ('" +
                    textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" +
                    textBox5.Text + "', '" + textBox6.Text + "', '" +
                    textBox7.Text + "', " + textBox8.Text + ", '" + textBox9.Text + "', '" +
                    textBox10.Text + "', '" + textBox11.Text + "', '" + textBox12.Text + "', " +
                    textBox13.Text + ", " + textBox14.Text + ", " + textBox15.Text + ", " + textBox16.Text + ", '" +
                    textBox17.Text + "', '" + textBox18.Text + "', '" +
                    textBox19.Text + "', '" + textBox20.Text + "')";
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
        }

        private void SetDefaultText()
        {
            textBox2.Text = "男";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "2000-01-01";
            textBox3.ForeColor = Color.Gray;
            textBox4.ReadOnly = false;
            textBox5.Text = "汉";
            textBox5.ForeColor = Color.Gray;
            textBox6.Text = "未缴费";
            textBox6.ForeColor = Color.Gray;
            textBox7.Text = "+86***********";
            textBox7.ForeColor = Color.Gray;
            textBox8.Text = "1701000";
            textBox8.ForeColor = Color.Gray;
            textBox9.Text = "高一";
            textBox9.ForeColor = Color.Gray;
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
            textBox17.ForeColor = Color.Gray;
            textBox17.Text = "优";
            textBox18.ForeColor = Color.Gray;
            textBox18.Text = "优";
            textBox19.ForeColor = Color.Gray;
            textBox19.Text = "优";
            textBox20.ForeColor = Color.Gray;
            textBox20.Text = "无说明";
            textBox1.ForeColor = Color.Gray;
        }

    }
}
