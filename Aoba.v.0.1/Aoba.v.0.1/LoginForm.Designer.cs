namespace Aoba.v._0._1
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleImg = new System.Windows.Forms.PictureBox();
            this.LogImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Link = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.TitleImg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogImg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(147, 61);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 180);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // TitleImg
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TitleImg, 2);
            this.TitleImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleImg.Image = ((System.Drawing.Image)(resources.GetObject("TitleImg.Image")));
            this.TitleImg.Location = new System.Drawing.Point(3, 3);
            this.TitleImg.Name = "TitleImg";
            this.TitleImg.Size = new System.Drawing.Size(325, 59);
            this.TitleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleImg.TabIndex = 0;
            this.TitleImg.TabStop = false;
            // 
            // LogImg
            // 
            this.LogImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogImg.Image = ((System.Drawing.Image)(resources.GetObject("LogImg.Image")));
            this.LogImg.Location = new System.Drawing.Point(3, 68);
            this.LogImg.Name = "LogImg";
            this.LogImg.Size = new System.Drawing.Size(118, 109);
            this.LogImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogImg.TabIndex = 2;
            this.LogImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Link);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Account);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(127, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 109);
            this.panel1.TabIndex = 3;
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(66, 83);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(75, 23);
            this.Link.TabIndex = 4;
            this.Link.Text = "登录";
            this.Link.UseVisualStyleBackColor = true;
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(66, 56);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 21);
            this.Password.TabIndex = 3;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(66, 18);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(100, 21);
            this.Account.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(463, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据源：119.29.110.245";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox TitleImg;
        private System.Windows.Forms.PictureBox LogImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Link;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

