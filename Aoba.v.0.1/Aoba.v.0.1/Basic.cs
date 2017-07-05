using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace Aoba.v._0._1
{
    static public class Basic
    {
        static public SqlConnection mylink;
        static public string connectionstring = "server=123.206.218.134;database=Believe;User Id=sa;Password=Silence_zero_0";
        public enum UserType
        {
            user = 0,
            teacher = 1,
            student = 2,
            course = 3,
            elective = 4
        };
        static public bool adduser(string id, string pwd, string type, string permission)
        {
            string sql = "INSERT INTO users (_Id, _Password, _Type, _Permission) VALUES(" + id + ",'" + pwd + "','" + type + "','" + permission + "')";
            SqlCommand cmd = new SqlCommand(sql, mylink);
            mylink.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.ToString());
            }
            finally
            {
                mylink.Close();
            }
            return true;
        }

        static public string InputBox()
        {
            Form InputForm = new Form();
            InputForm.MinimizeBox = false;
            InputForm.MaximizeBox = false;
            InputForm.StartPosition = FormStartPosition.CenterScreen;
            InputForm.Width = 270;
            InputForm.Height = 150;
            //InputForm.Font.Name = "宋体";
            //InputForm.Font.Size = 10;

            InputForm.Text = "设置登陆密码";
            Label lbl = new Label();
            lbl.Text = "PassWord";
            lbl.Left = 10;
            lbl.Top = 18;
            lbl.Parent = InputForm;
            lbl.AutoSize = true;

            TextBox tb1 = new TextBox();
            tb1.Left = 70;
            tb1.Top = 12;
            tb1.Width = 160;
            tb1.Parent = InputForm;
            tb1.PasswordChar = '*';
            tb1.SelectAll();

            Label lb2 = new Label();
            lb2.Text = "Confirm";
            lb2.Left = 10;
            lb2.Top = 48;
            lb2.Parent = InputForm;
            lb2.AutoSize = true;

            TextBox tb2 = new TextBox();
            tb2.Left = 70;
            tb2.Top = 42;
            tb2.Width = 160;
            tb2.Parent = InputForm;
            tb2.PasswordChar = '*';
            tb2.SelectAll();

            Button btnok = new Button();
            btnok.Left = 100;
            btnok.Top = 78;
            btnok.Parent = InputForm;
            btnok.Text = "确定";
            InputForm.AcceptButton = btnok;//回车响应
            btnok.DialogResult = DialogResult.OK;

            try
            {
                if (InputForm.ShowDialog() == DialogResult.OK)
                {
                    if (tb1.Text == tb2.Text && tb2.Text != String.Empty)
                    {
                        return tb2.Text;
                    }
                    else
                    {
                        return InputBox();
                    }
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                InputForm.Dispose();
            }

        }
    }
}
