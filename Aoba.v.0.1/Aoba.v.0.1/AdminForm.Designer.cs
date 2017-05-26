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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.System = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Teachers = new System.Windows.Forms.ToolStripMenuItem();
            this.Students = new System.Windows.Forms.ToolStripMenuItem();
            this.Courses = new System.Windows.Forms.ToolStripMenuItem();
            this.Elective = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.New = new System.Windows.Forms.ToolStripLabel();
            this.Updata = new System.Windows.Forms.ToolStripLabel();
            this.Qeury = new System.Windows.Forms.ToolStripLabel();
            this.Delete = new System.Windows.Forms.ToolStripLabel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tool.SuspendLayout();
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
            this.退出ToolStripMenuItem,
            this.切换用户ToolStripMenuItem,
            this.推出ToolStripMenuItem});
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(44, 21);
            this.System.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "数据源";
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.修改用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem,
            this.权限管理ToolStripMenuItem});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(68, 21);
            this.Users.Text = "用户管理";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            // 
            // 修改用户ToolStripMenuItem
            // 
            this.修改用户ToolStripMenuItem.Name = "修改用户ToolStripMenuItem";
            this.修改用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改用户ToolStripMenuItem.Text = "修改用户";
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(658, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // Teachers
            // 
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(68, 21);
            this.Teachers.Text = "教师管理";
            // 
            // Students
            // 
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(68, 21);
            this.Students.Text = "学生管理";
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
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.切换用户ToolStripMenuItem.Text = "切换用户";
            // 
            // 推出ToolStripMenuItem
            // 
            this.推出ToolStripMenuItem.Name = "推出ToolStripMenuItem";
            this.推出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.推出ToolStripMenuItem.Text = "退出";
            // 
            // Tool
            // 
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Updata,
            this.Qeury,
            this.Delete});
            this.Tool.Location = new System.Drawing.Point(0, 25);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(682, 25);
            this.Tool.TabIndex = 3;
            this.Tool.Text = "toolStrip1";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(32, 22);
            this.New.Text = "新建";
            // 
            // Updata
            // 
            this.Updata.Name = "Updata";
            this.Updata.Size = new System.Drawing.Size(32, 22);
            this.Updata.Text = "修改";
            // 
            // Qeury
            // 
            this.Qeury.Name = "Qeury";
            this.Qeury.Size = new System.Drawing.Size(32, 22);
            this.Qeury.Text = "查询";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(32, 22);
            this.Delete.Text = "删除";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 350);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem System;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Teachers;
        private System.Windows.Forms.ToolStripMenuItem Students;
        private System.Windows.Forms.ToolStripMenuItem Courses;
        private System.Windows.Forms.ToolStripMenuItem Elective;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripLabel New;
        private System.Windows.Forms.ToolStripLabel Updata;
        private System.Windows.Forms.ToolStripLabel Qeury;
        private System.Windows.Forms.ToolStripLabel Delete;
    }
}