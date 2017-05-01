using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Aoba.v._0._1
{
    public partial class Login : Form
    {
        SqlConnection aoba = new SqlConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void Link_Click(object sender, EventArgs e)
        {
            string str = "server=119.29.110.245;database=Aoba;uid="+Account.Text+";pwd="+Password.Text;

            try
            {
                aoba.ConnectionString = str;
                aoba.Open();
                MessageBox.Show("登陆成功！");
                //这里需要对账号做一个验证，判断是管理员还是教师还是学生
                //然后打开对应的窗口
                //调用另外的窗口，关闭此窗口
                switch(get_Type(Account.Text))
                {
                    case 1:AdminForm admin = new AdminForm(); break; //表示管理员，进入管理员界面
                    case 2:TeacherForm teacher = new TeacherForm(); break; //表示教师，进入教师查询界面
                    case 3:StudentForm student = new StudentForm(); break; //表示学生，进入学生个人信息界面
                    case 4:CommonForm common = new CommonForm(); break; //表示公共临时账号，进入公共查询界面
                    default:MessageBox.Show("信息丢失，请检查数据库！");break;
                }
                this.Close(); //关闭登录界面
            }
            catch
            {
                MessageBox.Show("登陆失败\n请确保账号密码正确");
            }
        }

        private int get_Type(string account)
        {
            return 1;
        }
    }
}
