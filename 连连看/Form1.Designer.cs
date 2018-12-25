namespace 连连看
{
    partial class Form1
    {
        const int MAXSIZE = 8;
        const int PICSIZE = 100;

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
            rd = new System.Random();
            this.pic = new System.Windows.Forms.PictureBox[MAXSIZE,MAXSIZE];
            for(int i=0;i<MAXSIZE;++i)
            {
                for(int j=0;j<MAXSIZE;++j)
                {
                    this.pic[i,j] = new System.Windows.Forms.PictureBox();
                    //   this.pic[i, j].Image = global::连连看.Properties.Resources."_"+(rd.Next(0, 16) + 1).ToString();
                    this.pic[i, j].Location = new System.Drawing.Point(50+PICSIZE*i, 25+ PICSIZE * j);
                    this.pic[i, j].Name = "pic"+(i*MAXSIZE+j).ToString();
                    this.pic[i, j].Size = new System.Drawing.Size(PICSIZE, PICSIZE);
                    this.pic[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.pic[i, j].TabIndex = 1;
                    this.pic[i, j].TabStop = false;
                    this.pic[i, j].Click += new System.EventHandler(this.PicClick);
                    this.Controls.Add(this.pic[i, j]);
                }
            }
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "消除一个";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enabled = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(881, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "开始游戏";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "连连看";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox [,]pic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

