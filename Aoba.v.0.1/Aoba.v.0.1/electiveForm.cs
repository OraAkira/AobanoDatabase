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
            string sql = "SELECT _Name, _Grade FROM student WHERE _Id=" + id;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            try
            {
                Basic.mylink.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    grade = reader["_Grade"].ToString();
                    grade = Regex.Replace(grade, @"\s", "");
                    name = reader["_Name"].ToString();
                }
                label2.Text = name;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Basic.mylink.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control tmp in groupBox1.Controls)
            {
                if(tmp is CheckBox)
                {
                    CheckBox ck = tmp as CheckBox;
                    string sql = "SELECT student._Id as StuId, course._Id as CouId from student, course WHERE student._Name='" + name + "' AND course._Name='" + grade + ck.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
                    Basic.mylink.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    string sid = "0000", cid = "0000";
                    while(reader.Read())
                    {
                        sid = reader["StuId"].ToString();
                        cid = reader["CouId"].ToString();
                    }
                    Basic.mylink.Close();
                    if(sid != "0000" || cid != "0000")
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
                                    sql = "INSERT INTO elective (_IdStu, _IdCou, _Name) VALUES(" + sid + "," + cid + ", '" + grade + ck.Text + "')";
                                    MessageBox.Show(sql);
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
                        finally
                        {

                        }
                    }
                }
            }
            
        }
    }
}
