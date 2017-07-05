using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Aoba.v._0._1
{
    public partial class electiveForm : Form
    {
        private string grade, name;
        public electiveForm()
        {
            InitializeComponent();
        }

        public electiveForm(string id)
        {
            InitializeComponent();
            string sql = "SELECT _Name FROM student WHERE _Id=" + id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name = reader["_Name"].ToString();
                }
                label2.Text = name;
                label3.Text = id;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Basic.mylink.Close();
            }
            CreatCheckBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryFrom query = new QueryFrom(Basic.UserType.student);
            query.ShowDialog();
            try
            {
                SqlCommand cmd = new SqlCommand(query.sql, Basic.mylink);
                Basic.mylink.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    label2.Text = datareader["_Name"].ToString();
                    label3.Text = datareader["_Id"].ToString();
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control tmp in groupBox1.Controls)
            {
                if (tmp is CheckBox)
                {
                    CheckBox ck = tmp as CheckBox;
                    string sql = "SELECT student._Id as StuId, course._Id as CouId from student, course WHERE student._Name='" + name + "' AND course._Name='" + ck.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                    Basic.mylink.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    string sid = "0000", cid = "0000";
                    while (reader.Read())
                    {
                        sid = reader["StuId"].ToString();
                        cid = reader["CouId"].ToString();
                    }
                    Basic.mylink.Close();
                    if (sid != "0000" || cid != "0000")
                    {
                        sql = "SELECT * FROM elective WHERE _IdStu=" + sid + " AND _IdCou=" + cid;
                        cmd.Dispose();
                        cmd = new SqlCommand(sql, Basic.mylink);
                        try
                        {
                            Basic.mylink.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                cmd.Dispose();
                                Basic.mylink.Close();
                                if (!ck.Checked)
                                {
                                    sql = "DELETE FROM elective WHERE _IdEle = (" + sid + "," + cid + ")";
                                    cmd = new SqlCommand(sql, Basic.mylink);
                                    try
                                    {
                                        Basic.mylink.Open();
                                        cmd.ExecuteNonQuery();
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
                            }
                            else
                            {
                                cmd.Dispose();
                                Basic.mylink.Close();
                                if (ck.Checked)
                                {
                                    sql = "INSERT INTO elective (_IdStu, _IdCou) VALUES(" + sid + "," + cid + ")";
                                    cmd = new SqlCommand(sql, Basic.mylink);
                                    try
                                    {
                                        Basic.mylink.Open();
                                        cmd.ExecuteNonQuery();
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
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("错误代码：" + ex.ToString());
                        }
                    }
                }
            }

        }

        private void CreatCheckBox()
        {
            string sql = "SELECT _Name FROM course";
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0, j = 0, cnt = 0;
                while(reader.Read())
                {
                    cnt++;
                    CheckBox tmp = new CheckBox();
                    tmp.Parent = groupBox1;
                    tmp.Text = reader["_Name"].ToString();
                    tmp.Name = "CheckBox" + cnt.ToString();
                    tmp.Left = j * 120 + 12;
                    tmp.Top = i * 24 + 12;
                    j++;
                    if(j == 3)
                    {
                        i++;
                        j = 1;
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.ToString());
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
    }
}
