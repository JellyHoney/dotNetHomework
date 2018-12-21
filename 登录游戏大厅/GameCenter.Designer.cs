namespace 登录游戏大厅
{
    partial class GameCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::登录游戏大厅.Properties.Resources.gamecenter_bg;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameCenter";
            this.Text = "GameCenter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameCenter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameCenter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameCenter_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}