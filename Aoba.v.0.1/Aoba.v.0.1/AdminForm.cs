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

        private void 增加教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
