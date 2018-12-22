namespace 登录游戏大厅
{
    partial class login
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimized = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.注册账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLogin.Location = new System.Drawing.Point(58, 308);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(179, 32);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(266, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(20, 20);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimized
            // 
            this.BtnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimized.FlatAppearance.BorderSize = 0;
            this.BtnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimized.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimized.Location = new System.Drawing.Point(238, 2);
            this.BtnMinimized.Name = "BtnMinimized";
            this.BtnMinimized.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimized.TabIndex = 7;
            this.BtnMinimized.UseVisualStyleBackColor = false;
            this.BtnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Location = new System.Drawing.Point(210, 2);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(20, 20);
            this.BtnMenu.TabIndex = 8;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册账号ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 注册账号ToolStripMenuItem
            // 
            this.注册账号ToolStripMenuItem.Name = "注册账号ToolStripMenuItem";
            this.注册账号ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注册账号ToolStripMenuItem.Text = "注册账号";
            this.注册账号ToolStripMenuItem.Click += new System.EventHandler(this.注册账号ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(57, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 14);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "账号";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(57, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 14);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "密码";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::登录游戏大厅.Properties.Resources.login_bg;
            this.ClientSize = new System.Drawing.Size(298, 414);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnMinimized);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launch_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launch_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Launch_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimized;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 注册账号ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

