using System.Windows.Forms;

namespace Aoba.v._0._1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.System = new System.Windows.Forms.ToolStripMenuItem();
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.Teachers = new System.Windows.Forms.ToolStripMenuItem();
            this.Students = new System.Windows.Forms.ToolStripMenuItem();
            this.Courses = new System.Windows.Forms.ToolStripMenuItem();
            this.Elective = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.System,
            this.Users,
            this.Teachers,
            this.Students,
            this.Courses,
            this.Elective,
            this.Help,
            this.About});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(682, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // System
            // 
            this.System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换用户ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(44, 21);
            this.System.Text = "系统";
            // 
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.切换用户ToolStripMenuItem.Text = "切换用户";
            this.切换用户ToolStripMenuItem.Click += new System.EventHandler(this.切换用户ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Users
            // 
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(68, 21);
            this.Users.Text = "用户管理";
            // 
            // Teachers
            // 
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(68, 21);
            this.Teachers.Text = "教师管理";
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // Students
            // 
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(68, 21);
            this.Students.Text = "学生管理";
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Courses
            // 
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(68, 21);
            this.Courses.Text = "课程管理";
            // 
            // Elective
            // 
            this.Elective.Name = "Elective";
            this.Elective.Size = new System.Drawing.Size(68, 21);
            this.Elective.Text = "学生选课";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 21);
            this.Help.Text = "帮助";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(44, 21);
            this.About.Text = "关于";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(682, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem1,
            this.查询ToolStripMenuItem2,
            this.修改ToolStripMenuItem2,
            this.删除ToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // 新增ToolStripMenuItem1
            // 
            this.新增ToolStripMenuItem1.Name = "新增ToolStripMenuItem1";
            this.新增ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.新增ToolStripMenuItem1.Text = "新增";
            this.新增ToolStripMenuItem1.Click += new System.EventHandler(this.新增ToolStripMenuItem1_Click);
            // 
            // 查询ToolStripMenuItem2
            // 
            this.查询ToolStripMenuItem2.Name = "查询ToolStripMenuItem2";
            this.查询ToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.查询ToolStripMenuItem2.Text = "查询";
            this.查询ToolStripMenuItem2.Click += new System.EventHandler(this.查询ToolStripMenuItem2_Click);
            // 
            // 修改ToolStripMenuItem2
            // 
            this.修改ToolStripMenuItem2.Name = "修改ToolStripMenuItem2";
            this.修改ToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem2.Text = "修改";
            this.修改ToolStripMenuItem2.Click += new System.EventHandler(this.修改ToolStripMenuItem2_Click);
            // 
            // 删除ToolStripMenuItem2
            // 
            this.删除ToolStripMenuItem2.Name = "删除ToolStripMenuItem2";
            this.删除ToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem2.Text = "删除";
            this.删除ToolStripMenuItem2.Click += new System.EventHandler(this.删除ToolStripMenuItem2_Click);
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(682, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem System;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem 切换用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Teachers;
        private System.Windows.Forms.ToolStripMenuItem Students;
        private System.Windows.Forms.ToolStripMenuItem Courses;
        private System.Windows.Forms.ToolStripMenuItem Elective;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 新增ToolStripMenuItem1;
        private ToolStripMenuItem 查询ToolStripMenuItem2;
        private ToolStripMenuItem 修改ToolStripMenuItem2;
        private ToolStripMenuItem 删除ToolStripMenuItem2;
    }
}