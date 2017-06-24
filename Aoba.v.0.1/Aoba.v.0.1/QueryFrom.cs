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
    public partial class QueryFrom : Form
    {
        private string tablename;
        public string sql;
        public QueryFrom(int index)
        {
            InitializeComponent();
            switch (index)
            {
                case 1: tablename = "user"; break;
                case 2: tablename = "student"; break;
                case 3: tablename = "teacher"; break;
                case 4: tablename = "course"; break;
                default: break;
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM " + tablename + " WHERE ";
            if (comboBox1.SelectedItem.ToString() == "按照ID查询")
                sql += "_Id =" + textBox1.Text;
            else
                sql += "_Name='" + textBox1.Text + "'";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
