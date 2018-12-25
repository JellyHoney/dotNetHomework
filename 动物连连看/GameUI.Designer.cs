namespace 动物连连看
{
    partial class GameUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.BoomButton = new System.Windows.Forms.Button();
            this.FreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::动物连连看.Properties.Resources.picboardbg;
            this.panel1.Location = new System.Drawing.Point(88, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 384);
            this.panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Location = new System.Drawing.Point(675, 30);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(100, 69);
            this.menuButton.TabIndex = 2;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // BoomButton
            // 
            this.BoomButton.BackColor = System.Drawing.Color.Transparent;
            this.BoomButton.FlatAppearance.BorderSize = 0;
            this.BoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoomButton.Location = new System.Drawing.Point(723, 538);
            this.BoomButton.Name = "BoomButton";
            this.BoomButton.Size = new System.Drawing.Size(45, 45);
            this.BoomButton.TabIndex = 3;
            this.BoomButton.UseVisualStyleBackColor = false;
            this.BoomButton.Click += new System.EventHandler(this.BoomButton_Click);
            // 
            // FreshButton
            // 
            this.FreshButton.BackColor = System.Drawing.Color.Transparent;
            this.FreshButton.FlatAppearance.BorderSize = 0;
            this.FreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreshButton.Location = new System.Drawing.Point(672, 538);
            this.FreshButton.Name = "FreshButton";
            this.FreshButton.Size = new System.Drawing.Size(45, 45);
            this.FreshButton.TabIndex = 4;
            this.FreshButton.UseVisualStyleBackColor = false;
            this.FreshButton.Click += new System.EventHandler(this.FreshButton_Click);
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::动物连连看.Properties.Resources.gamebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.FreshButton);
            this.Controls.Add(this.BoomButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.panel1);
            this.Name = "GameUI";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button BoomButton;
        private System.Windows.Forms.Button FreshButton;
    }
}
