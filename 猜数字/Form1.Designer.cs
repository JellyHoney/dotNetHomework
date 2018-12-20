namespace 猜数字
{
    partial class Form1
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
        /// 
        private void MyInitializeComponent()
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {

                    this.num[i * 10 + j] = new System.Windows.Forms.Button();
                    this.num[i * 10 + j].Location = new System.Drawing.Point(j * 30, i * 30);
                    this.num[i * 10 + j].Name = (i*10+j).ToString();
                    this.num[i * 10 + j].Size = new System.Drawing.Size(25, 25);
                    this.num[i * 10 + j].TabIndex = 1;
                    this.num[i * 10 + j].Text = (i*10+j).ToString();
                    this.num[i * 10 + j].UseVisualStyleBackColor = true;
                    this.Controls.Add(this.num[i * 10 + j]);
                    this.num[i * 10 + j].Click += new System.EventHandler(this.num_Click);
                }

            }
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "再来一局";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "得分:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(53, 329);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(11, 12);
            this.score.TabIndex = 5;
            this.score.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "总分:";
            // 
            // totScore
            // 
            this.totScore.AutoSize = true;
            this.totScore.Location = new System.Drawing.Point(143, 329);
            this.totScore.Name = "totScore";
            this.totScore.Size = new System.Drawing.Size(11, 12);
            this.totScore.TabIndex = 7;
            this.totScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 347);
            this.Controls.Add(this.totScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "猜数字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button[] num=new System.Windows.Forms.Button[100];
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totScore;
    }
}

