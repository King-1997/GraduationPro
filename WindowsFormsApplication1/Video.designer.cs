namespace WindowsFormsApplication1
{
    partial class Video
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_return = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(106, 74);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(546, 342);
            this.player.TabIndex = 0;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_return.DownBack = null;
            this.btn_return.Location = new System.Drawing.Point(604, 485);
            this.btn_return.MouseBack = null;
            this.btn_return.Name = "btn_return";
            this.btn_return.NormlBack = null;
            this.btn_return.Size = new System.Drawing.Size(91, 37);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.player);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频";
            this.Load += new System.EventHandler(this.Video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private CCWin.SkinControl.SkinButton btn_return;
    }
}