namespace 打地鼠
{
    partial class Launch
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
            this.components = new System.ComponentModel.Container();
            this.PicQuit = new System.Windows.Forms.PictureBox();
            this.PicNewGame = new System.Windows.Forms.PictureBox();
            this.PicContinueGame = new System.Windows.Forms.PictureBox();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicSetting = new System.Windows.Forms.PictureBox();
            this.PicIntroduce = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.PicTimer = new System.Windows.Forms.PictureBox();
            this.timeRest = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.mouseGen = new System.Windows.Forms.Timer(this.components);
            this.mouse1 = new System.Windows.Forms.PictureBox();
            this.mouse2 = new System.Windows.Forms.PictureBox();
            this.mouse3 = new System.Windows.Forms.PictureBox();
            this.mouse4 = new System.Windows.Forms.PictureBox();
            this.mouse5 = new System.Windows.Forms.PictureBox();
            this.mouse6 = new System.Windows.Forms.PictureBox();
            this.mouse7 = new System.Windows.Forms.PictureBox();
            this.mouse8 = new System.Windows.Forms.PictureBox();
            this.mouse9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicContinueGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIntroduce)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse9)).BeginInit();
            this.SuspendLayout();
            // 
            // PicQuit
            // 
            this.PicQuit.BackColor = System.Drawing.Color.Transparent;
            this.PicQuit.Image = global::打地鼠.Properties.Resources.退出;
            this.PicQuit.Location = new System.Drawing.Point(3, 311);
            this.PicQuit.Name = "PicQuit";
            this.PicQuit.Size = new System.Drawing.Size(187, 71);
            this.PicQuit.TabIndex = 0;
            this.PicQuit.TabStop = false;
            this.PicQuit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicNewGame
            // 
            this.PicNewGame.BackColor = System.Drawing.Color.Transparent;
            this.PicNewGame.Image = global::打地鼠.Properties.Resources.新游戏;
            this.PicNewGame.Location = new System.Drawing.Point(3, 3);
            this.PicNewGame.Name = "PicNewGame";
            this.PicNewGame.Size = new System.Drawing.Size(187, 71);
            this.PicNewGame.TabIndex = 1;
            this.PicNewGame.TabStop = false;
            this.PicNewGame.Click += new System.EventHandler(this.PicNewGame_Click);
            // 
            // PicContinueGame
            // 
            this.PicContinueGame.BackColor = System.Drawing.Color.Transparent;
            this.PicContinueGame.Image = global::打地鼠.Properties.Resources.继续游戏;
            this.PicContinueGame.Location = new System.Drawing.Point(3, 80);
            this.PicContinueGame.Name = "PicContinueGame";
            this.PicContinueGame.Size = new System.Drawing.Size(187, 71);
            this.PicContinueGame.TabIndex = 2;
            this.PicContinueGame.TabStop = false;
            // 
            // PicTitle
            // 
            this.PicTitle.BackColor = System.Drawing.Color.Transparent;
            this.PicTitle.Image = global::打地鼠.Properties.Resources.打地鼠1;
            this.PicTitle.Location = new System.Drawing.Point(12, 31);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(369, 156);
            this.PicTitle.TabIndex = 3;
            this.PicTitle.TabStop = false;
            this.PicTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicTitle_MouseDown);
            this.PicTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicTitle_MouseMove);
            this.PicTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicTitle_MouseUp);
            // 
            // PicSetting
            // 
            this.PicSetting.BackColor = System.Drawing.Color.Transparent;
            this.PicSetting.Image = global::打地鼠.Properties.Resources.设置;
            this.PicSetting.Location = new System.Drawing.Point(3, 157);
            this.PicSetting.Name = "PicSetting";
            this.PicSetting.Size = new System.Drawing.Size(187, 71);
            this.PicSetting.TabIndex = 4;
            this.PicSetting.TabStop = false;
            // 
            // PicIntroduce
            // 
            this.PicIntroduce.BackColor = System.Drawing.Color.Transparent;
            this.PicIntroduce.Image = global::打地鼠.Properties.Resources.游戏说明;
            this.PicIntroduce.Location = new System.Drawing.Point(3, 234);
            this.PicIntroduce.Name = "PicIntroduce";
            this.PicIntroduce.Size = new System.Drawing.Size(187, 71);
            this.PicIntroduce.TabIndex = 5;
            this.PicIntroduce.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.PicNewGame);
            this.menuPanel.Controls.Add(this.PicIntroduce);
            this.menuPanel.Controls.Add(this.PicQuit);
            this.menuPanel.Controls.Add(this.PicContinueGame);
            this.menuPanel.Controls.Add(this.PicSetting);
            this.menuPanel.Location = new System.Drawing.Point(594, 99);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(194, 390);
            this.menuPanel.TabIndex = 7;
            // 
            // PicTimer
            // 
            this.PicTimer.BackColor = System.Drawing.Color.Transparent;
            this.PicTimer.BackgroundImage = global::打地鼠.Properties.Resources.计时;
            this.PicTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicTimer.Location = new System.Drawing.Point(12, 531);
            this.PicTimer.Name = "PicTimer";
            this.PicTimer.Size = new System.Drawing.Size(772, 57);
            this.PicTimer.TabIndex = 6;
            this.PicTimer.TabStop = false;
            // 
            // timeRest
            // 
            this.timeRest.BackColor = System.Drawing.Color.GreenYellow;
            this.timeRest.Location = new System.Drawing.Point(110, 568);
            this.timeRest.Name = "timeRest";
            this.timeRest.Size = new System.Drawing.Size(360, 12);
            this.timeRest.TabIndex = 8;
            // 
            // gameTime
            // 
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // mouseGen
            // 
            this.mouseGen.Interval = 1000;
            this.mouseGen.Tick += new System.EventHandler(this.mouseGen_Tick);
            // 
            // mouse1
            // 
            this.mouse1.BackColor = System.Drawing.Color.Transparent;
            this.mouse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse1.Location = new System.Drawing.Point(148, 139);
            this.mouse1.Name = "mouse1";
            this.mouse1.Size = new System.Drawing.Size(102, 102);
            this.mouse1.TabIndex = 9;
            this.mouse1.TabStop = false;
            // 
            // mouse2
            // 
            this.mouse2.BackColor = System.Drawing.Color.Transparent;
            this.mouse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse2.Location = new System.Drawing.Point(333, 137);
            this.mouse2.Name = "mouse2";
            this.mouse2.Size = new System.Drawing.Size(102, 102);
            this.mouse2.TabIndex = 10;
            this.mouse2.TabStop = false;
            // 
            // mouse3
            // 
            this.mouse3.BackColor = System.Drawing.Color.Transparent;
            this.mouse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse3.Location = new System.Drawing.Point(534, 142);
            this.mouse3.Name = "mouse3";
            this.mouse3.Size = new System.Drawing.Size(102, 102);
            this.mouse3.TabIndex = 11;
            this.mouse3.TabStop = false;
            // 
            // mouse4
            // 
            this.mouse4.BackColor = System.Drawing.Color.Transparent;
            this.mouse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse4.Location = new System.Drawing.Point(116, 254);
            this.mouse4.Name = "mouse4";
            this.mouse4.Size = new System.Drawing.Size(102, 102);
            this.mouse4.TabIndex = 12;
            this.mouse4.TabStop = false;
            // 
            // mouse5
            // 
            this.mouse5.BackColor = System.Drawing.Color.Transparent;
            this.mouse5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse5.Location = new System.Drawing.Point(337, 253);
            this.mouse5.Name = "mouse5";
            this.mouse5.Size = new System.Drawing.Size(102, 102);
            this.mouse5.TabIndex = 13;
            this.mouse5.TabStop = false;
            // 
            // mouse6
            // 
            this.mouse6.BackColor = System.Drawing.Color.Transparent;
            this.mouse6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse6.Location = new System.Drawing.Point(536, 251);
            this.mouse6.Name = "mouse6";
            this.mouse6.Size = new System.Drawing.Size(102, 102);
            this.mouse6.TabIndex = 14;
            this.mouse6.TabStop = false;
            // 
            // mouse7
            // 
            this.mouse7.BackColor = System.Drawing.Color.Transparent;
            this.mouse7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse7.Location = new System.Drawing.Point(109, 372);
            this.mouse7.Name = "mouse7";
            this.mouse7.Size = new System.Drawing.Size(102, 102);
            this.mouse7.TabIndex = 15;
            this.mouse7.TabStop = false;
            // 
            // mouse8
            // 
            this.mouse8.BackColor = System.Drawing.Color.Transparent;
            this.mouse8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse8.Location = new System.Drawing.Point(334, 379);
            this.mouse8.Name = "mouse8";
            this.mouse8.Size = new System.Drawing.Size(102, 102);
            this.mouse8.TabIndex = 16;
            this.mouse8.TabStop = false;
            // 
            // mouse9
            // 
            this.mouse9.BackColor = System.Drawing.Color.Transparent;
            this.mouse9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouse9.Location = new System.Drawing.Point(559, 381);
            this.mouse9.Name = "mouse9";
            this.mouse9.Size = new System.Drawing.Size(102, 102);
            this.mouse9.TabIndex = 17;
            this.mouse9.TabStop = false;
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::打地鼠.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PicTitle);
            this.Controls.Add(this.mouse8);
            this.Controls.Add(this.mouse7);
            this.Controls.Add(this.mouse5);
            this.Controls.Add(this.mouse4);
            this.Controls.Add(this.mouse2);
            this.Controls.Add(this.mouse1);
            this.Controls.Add(this.timeRest);
            this.Controls.Add(this.PicTimer);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.mouse9);
            this.Controls.Add(this.mouse6);
            this.Controls.Add(this.mouse3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launch";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HammerDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicContinueGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIntroduce)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicQuit;
        private System.Windows.Forms.PictureBox PicNewGame;
        private System.Windows.Forms.PictureBox PicContinueGame;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicSetting;
        private System.Windows.Forms.PictureBox PicIntroduce;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox PicTimer;
        private System.Windows.Forms.Label timeRest;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Timer mouseGen;
        private System.Windows.Forms.PictureBox mouse1;
        private System.Windows.Forms.PictureBox mouse2;
        private System.Windows.Forms.PictureBox mouse3;
        private System.Windows.Forms.PictureBox mouse4;
        private System.Windows.Forms.PictureBox mouse5;
        private System.Windows.Forms.PictureBox mouse6;
        private System.Windows.Forms.PictureBox mouse7;
        private System.Windows.Forms.PictureBox mouse8;
        private System.Windows.Forms.PictureBox mouse9;
    }
}

