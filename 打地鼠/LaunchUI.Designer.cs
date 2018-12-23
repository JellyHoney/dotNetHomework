namespace 打地鼠
{
    partial class LaunchUI
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
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicNewGame = new System.Windows.Forms.PictureBox();
            this.PicIntroduce = new System.Windows.Forms.PictureBox();
            this.PicQuit = new System.Windows.Forms.PictureBox();
            this.PicContinueGame = new System.Windows.Forms.PictureBox();
            this.PicSetting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIntroduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicContinueGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // PicTitle
            // 
            this.PicTitle.BackColor = System.Drawing.Color.Transparent;
            this.PicTitle.Image = global::打地鼠.Properties.Resources.打地鼠1;
            this.PicTitle.Location = new System.Drawing.Point(3, 115);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(369, 156);
            this.PicTitle.TabIndex = 4;
            this.PicTitle.TabStop = false;
            this.PicTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicTitle_MouseDown);
            this.PicTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicTitle_MouseMove);
            this.PicTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicTitle_MouseUp);
            // 
            // PicNewGame
            // 
            this.PicNewGame.BackColor = System.Drawing.Color.Transparent;
            this.PicNewGame.Image = global::打地鼠.Properties.Resources.新游戏;
            this.PicNewGame.Location = new System.Drawing.Point(585, 115);
            this.PicNewGame.Name = "PicNewGame";
            this.PicNewGame.Size = new System.Drawing.Size(187, 71);
            this.PicNewGame.TabIndex = 1;
            this.PicNewGame.TabStop = false;
            this.PicNewGame.Click += new System.EventHandler(this.PicNewGame_Click);
            // 
            // PicIntroduce
            // 
            this.PicIntroduce.BackColor = System.Drawing.Color.Transparent;
            this.PicIntroduce.Image = global::打地鼠.Properties.Resources.游戏说明;
            this.PicIntroduce.Location = new System.Drawing.Point(585, 346);
            this.PicIntroduce.Name = "PicIntroduce";
            this.PicIntroduce.Size = new System.Drawing.Size(187, 71);
            this.PicIntroduce.TabIndex = 5;
            this.PicIntroduce.TabStop = false;
            this.PicIntroduce.Click += new System.EventHandler(this.PicIntroduce_Click);
            // 
            // PicQuit
            // 
            this.PicQuit.BackColor = System.Drawing.Color.Transparent;
            this.PicQuit.Image = global::打地鼠.Properties.Resources.退出;
            this.PicQuit.Location = new System.Drawing.Point(585, 423);
            this.PicQuit.Name = "PicQuit";
            this.PicQuit.Size = new System.Drawing.Size(187, 71);
            this.PicQuit.TabIndex = 0;
            this.PicQuit.TabStop = false;
            this.PicQuit.Click += new System.EventHandler(this.PicQuit_Click);
            // 
            // PicContinueGame
            // 
            this.PicContinueGame.BackColor = System.Drawing.Color.Transparent;
            this.PicContinueGame.Image = global::打地鼠.Properties.Resources.继续游戏;
            this.PicContinueGame.Location = new System.Drawing.Point(585, 192);
            this.PicContinueGame.Name = "PicContinueGame";
            this.PicContinueGame.Size = new System.Drawing.Size(187, 71);
            this.PicContinueGame.TabIndex = 2;
            this.PicContinueGame.TabStop = false;
            this.PicContinueGame.Click += new System.EventHandler(this.PicContinueGame_Click);
            // 
            // PicSetting
            // 
            this.PicSetting.BackColor = System.Drawing.Color.Transparent;
            this.PicSetting.Image = global::打地鼠.Properties.Resources.设置;
            this.PicSetting.Location = new System.Drawing.Point(585, 269);
            this.PicSetting.Name = "PicSetting";
            this.PicSetting.Size = new System.Drawing.Size(187, 71);
            this.PicSetting.TabIndex = 4;
            this.PicSetting.TabStop = false;
            this.PicSetting.Click += new System.EventHandler(this.PicSetting_Click);
            // 
            // LaunchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::打地鼠.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PicQuit);
            this.Controls.Add(this.PicIntroduce);
            this.Controls.Add(this.PicNewGame);
            this.Controls.Add(this.PicSetting);
            this.Controls.Add(this.PicContinueGame);
            this.Controls.Add(this.PicTitle);
            this.Name = "LaunchUI";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIntroduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicContinueGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicNewGame;
        private System.Windows.Forms.PictureBox PicIntroduce;
        private System.Windows.Forms.PictureBox PicQuit;
        private System.Windows.Forms.PictureBox PicContinueGame;
        private System.Windows.Forms.PictureBox PicSetting;
    }
}
