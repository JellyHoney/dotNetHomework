namespace 计算器
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
        private void MyInit()
        {
            this.buttonNum = new System.Windows.Forms.Button[10];
            this.buttonOp = new System.Windows.Forms.Button[4];
            const int INDEX = 8;
            const int BASE = 200;
            int x = 0 + INDEX, y = BASE;
            for (int i = 0; i < 10; ++i)
            {
                this.buttonNum[i] = new System.Windows.Forms.Button();
                this.buttonNum[i].Location = new System.Drawing.Point(x, y);
                x += 60;
                if (i % 3 == 0)
                {
                    y -= 30;
                    x = 0 + INDEX;
                }
                this.buttonNum[i].Name = i.ToString();
                this.buttonNum[i].Size = new System.Drawing.Size(50, 23);
                this.buttonNum[i].TabIndex = 1;
                this.buttonNum[i].Text = i.ToString();
                this.buttonNum[i].UseVisualStyleBackColor = true;
                this.Controls.Add(this.buttonNum[i]);
                this.buttonNum[i].Click += new System.EventHandler(this.buttonNumClick);
            }
            x = 180 + INDEX;
            y = BASE;
            for (int i = 0; i < 4; ++i)
            {
                this.buttonOp[i] = new System.Windows.Forms.Button();
                this.buttonOp[i].Location = new System.Drawing.Point(x, y);
                y -= 30;
             //   this.buttonOp[i].Name = i.ToString();
                this.buttonOp[i].Size = new System.Drawing.Size(50, 23);
                this.buttonOp[i].TabIndex = 1;
             //   this.buttonOp[i].Text = i.ToString();
                this.buttonOp[i].UseVisualStyleBackColor = true;
                this.Controls.Add(this.buttonOp[i]);
                this.buttonOp[i].Click += new System.EventHandler(this.buttonOpClick);
            }
            this.buttonOp[0].Name = "+";
            this.buttonOp[0].Text = "+";
            this.buttonOp[1].Name = "-";
            this.buttonOp[1].Text = "-";
            this.buttonOp[2].Name = "*";
            this.buttonOp[2].Text = "*";
            this.buttonOp[3].Name = "/";
            this.buttonOp[3].Text = "/";
            //Equal
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonEqual.Location = new System.Drawing.Point(120 + INDEX, BASE);
            this.buttonEqual.Name = "=";
            this.buttonEqual.Size = new System.Drawing.Size(50, 23);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqualClick);
            this.Controls.Add(this.buttonEqual);

            //Dot
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonEqual.Location = new System.Drawing.Point(60 + INDEX, BASE);
            this.buttonEqual.Name = ".";
            this.buttonEqual.Size = new System.Drawing.Size(50, 23);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.Text = ".";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonDotClick);
            this.Controls.Add(this.buttonEqual);
            //BackSpace
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonEqual.Location = new System.Drawing.Point(0 + INDEX, BASE-120);
            this.buttonEqual.Name = "BackSpace";
            this.buttonEqual.Size = new System.Drawing.Size(110, 23);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.Text = "BackSpace";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonBackSpaceClick);
            this.Controls.Add(this.buttonEqual);
            //Clear
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonEqual.Location = new System.Drawing.Point(120 + INDEX, BASE-120);
            this.buttonEqual.Name = "Clear";
            this.buttonEqual.Size = new System.Drawing.Size(110, 23);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.Text = "C";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonClearClick);
            this.Controls.Add(this.buttonEqual);

        }
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 239);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button[] buttonNum;
        private System.Windows.Forms.Button[] buttonOp;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonClear;
    }
}

