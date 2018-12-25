namespace 动物连连看
{
    partial class PauseUI
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.continueButton = new System.Windows.Forms.Button();
            this.ReturnMenuButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Location = new System.Drawing.Point(325, 327);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(155, 38);
            this.continueButton.TabIndex = 3;
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // ReturnMenuButton
            // 
            this.ReturnMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnMenuButton.FlatAppearance.BorderSize = 0;
            this.ReturnMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnMenuButton.Location = new System.Drawing.Point(325, 429);
            this.ReturnMenuButton.Name = "ReturnMenuButton";
            this.ReturnMenuButton.Size = new System.Drawing.Size(155, 38);
            this.ReturnMenuButton.TabIndex = 4;
            this.ReturnMenuButton.UseVisualStyleBackColor = false;
            this.ReturnMenuButton.Click += new System.EventHandler(this.ReturnMenuButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Transparent;
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(325, 379);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(155, 38);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(612, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 56);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelpButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::动物连连看.Properties.Resources.pausebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ReturnMenuButton);
            this.Controls.Add(this.continueButton);
            this.Name = "HelpButton";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button ReturnMenuButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button button1;
    }
}
