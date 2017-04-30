using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Aoba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection testlink = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=119.29.110.245;database=Aoba;uid=sa;pwd=Silence_zero_0";
            try
            {
                testlink.ConnectionString = str;
                testlink.Open();
                MessageBox.Show("成功连接数据库");
                string sql = "SELECT * FROM student";
                SqlDataAdapter da = new SqlDataAdapter(sql, testlink);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("连接失败");
            }
            finally
            {
                testlink.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stuid = Interaction.InputBox("请输入学号");
            string sql = "SELECT _Id, _Name, _Grade FROM student WHERE _Id = " + stuid;
            da = new SqlDataAdapter(sql, testlink);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
