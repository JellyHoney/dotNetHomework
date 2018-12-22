namespace 打地鼠
{
    partial class NextLevelUI
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
            this.LbThisScore = new System.Windows.Forms.Label();
            this.LbPassScore = new System.Windows.Forms.Label();
            this.LbTotalScore = new System.Windows.Forms.Label();
            this.LbThisLevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbThisScore
            // 
            this.LbThisScore.AutoSize = true;
            this.LbThisScore.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbThisScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbThisScore.Location = new System.Drawing.Point(156, 101);
            this.LbThisScore.Name = "LbThisScore";
            this.LbThisScore.Size = new System.Drawing.Size(25, 28);
            this.LbThisScore.TabIndex = 31;
            this.LbThisScore.Text = "0";
            // 
            // LbPassScore
            // 
            this.LbPassScore.AutoSize = true;
            this.LbPassScore.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPassScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbPassScore.Location = new System.Drawing.Point(325, 100);
            this.LbPassScore.Name = "LbPassScore";
            this.LbPassScore.Size = new System.Drawing.Size(25, 28);
            this.LbPassScore.TabIndex = 32;
            this.LbPassScore.Text = "0";
            // 
            // LbTotalScore
            // 
            this.LbTotalScore.AutoSize = true;
            this.LbTotalScore.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbTotalScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbTotalScore.Location = new System.Drawing.Point(115, 129);
            this.LbTotalScore.Name = "LbTotalScore";
            this.LbTotalScore.Size = new System.Drawing.Size(25, 28);
            this.LbTotalScore.TabIndex = 33;
            this.LbTotalScore.Text = "0";
            // 
            // LbThisLevel
            // 
            this.LbThisLevel.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbThisLevel.ForeColor = System.Drawing.Color.DarkOrange;
            this.LbThisLevel.Location = new System.Drawing.Point(270, 155);
            this.LbThisLevel.Name = "LbThisLevel";
            this.LbThisLevel.Size = new System.Drawing.Size(48, 63);
            this.LbThisLevel.TabIndex = 34;
            this.LbThisLevel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 48);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NextLevelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::打地鼠.Properties.Resources.恭喜过关1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbThisLevel);
            this.Controls.Add(this.LbTotalScore);
            this.Controls.Add(this.LbPassScore);
            this.Controls.Add(this.LbThisScore);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(180, 130);
            this.Name = "NextLevelUI";
            this.Size = new System.Drawing.Size(446, 339);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbThisScore;
        private System.Windows.Forms.Label LbPassScore;
        private System.Windows.Forms.Label LbTotalScore;
        private System.Windows.Forms.Label LbThisLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
