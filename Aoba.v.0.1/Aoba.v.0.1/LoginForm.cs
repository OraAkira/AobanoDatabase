using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Aoba.v._0._1
{
    public partial class Login : Form
    {
        private bool trueadmin;
        private bool isstu;
        public Login()
        {
            InitializeComponent();
            this.Show();
        }

        private void Link_Click(object sender, EventArgs e)
        {
            if(exsit(Account.Text, Password.Text))
            {
                //这里需要对账号做一个验证，判断是管理员还是教师还是学生
                //然后打开对应的窗口
                //调用另外的窗口，关闭此窗口
                int type = get_Type(Account.Text);
                if (type != -1)
                    MessageBox.Show("登陆成功！");
                switch (type)
                {
                    case 1: AdminForm admin = new AdminForm(trueadmin); admin.Show(); break; //表示管理员，进入管理员界面
                    case 2: TeacherForm teacher = new TeacherForm(Account.Text); teacher.Show(); break; //表示教师，进入教师查询界面
                    case 3: StudentForm student = new StudentForm(Account.Text,isstu); student.Show(); break; //表示学生，进入学生个人信息界面
                    case 4: AdminForm common = new AdminForm(trueadmin); common.Show(); break; //表示公共临时账号，进入公共查询界面
                    default: return;
                }
                this.Hide(); //关闭登录界面
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
        }

        private int get_Type(string account)
        {
            if(Account.Text == "Admin" && Password.Text == "123456")
            {
                trueadmin = true;
                return 1;
            }
            if (Account.Text == "public" && Password.Text == "123456")
            {
                trueadmin = false;
                return 1;
            }
            Regex rex = new Regex(@"^\d+$");
            if(!rex.IsMatch(Account.Text))
            {
                MessageBox.Show("此用户不存在！");
                return -1;
            }
            string sql = "SELECT * FROM users WHERE _Id=" + Account.Text;
            SqlCommand cmd = new SqlCommand(sql, Basic.mylink);
            Basic.mylink.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    if(Password.Text == reader["_Password"].ToString())
                    {
                        switch(reader["_Type"].ToString())
                        {
                            case "Administrator": return 1;
                            case "Teacher":return 2;
                            case "student": isstu = true; return 3;
                            case "public": return 4;
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误");
                    }
                }
                else
                {
                    MessageBox.Show("此用户不存在！");
                }
            }
            catch (SqlException ex)
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
            return -1;
        }

        private bool exsit(string users, string pwd)
        {
            if(users == string.Empty || pwd == string.Empty)
                return false;
            Basic.mylink = new SqlConnection(Basic.connectionstring);
            return true;
        }
    }
}
