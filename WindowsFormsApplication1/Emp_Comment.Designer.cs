namespace WindowsFormsApplication1
{
    partial class Emp_Comment
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
            this.ec_flp_comment = new System.Windows.Forms.FlowLayoutPanel();
            this.ec_lbl_userName = new System.Windows.Forms.Label();
            this.ec_lbl_user_name = new System.Windows.Forms.Label();
            this.ec_lbl_create_comm = new System.Windows.Forms.Label();
            this.ec_lbl_Comment = new System.Windows.Forms.Label();
            this.ec_tbx_comment = new System.Windows.Forms.TextBox();
            this.ec_btn_submit = new CCWin.SkinControl.SkinButton();
            this.ec_btn_cancel = new CCWin.SkinControl.SkinButton();
            this.ec_btn_return = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ec_flp_comment
            // 
            this.ec_flp_comment.Location = new System.Drawing.Point(89, 74);
            this.ec_flp_comment.Name = "ec_flp_comment";
            this.ec_flp_comment.Size = new System.Drawing.Size(654, 277);
            this.ec_flp_comment.TabIndex = 0;
            // 
            // ec_lbl_userName
            // 
            this.ec_lbl_userName.AutoSize = true;
            this.ec_lbl_userName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_userName.Location = new System.Drawing.Point(121, 404);
            this.ec_lbl_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_userName.Name = "ec_lbl_userName";
            this.ec_lbl_userName.Size = new System.Drawing.Size(44, 17);
            this.ec_lbl_userName.TabIndex = 32;
            this.ec_lbl_userName.Text = "名字：";
            // 
            // ec_lbl_user_name
            // 
            this.ec_lbl_user_name.AutoSize = true;
            this.ec_lbl_user_name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_user_name.Location = new System.Drawing.Point(192, 404);
            this.ec_lbl_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_user_name.Name = "ec_lbl_user_name";
            this.ec_lbl_user_name.Size = new System.Drawing.Size(32, 17);
            this.ec_lbl_user_name.TabIndex = 33;
            this.ec_lbl_user_name.Text = "名字";
            // 
            // ec_lbl_create_comm
            // 
            this.ec_lbl_create_comm.AutoSize = true;
            this.ec_lbl_create_comm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ec_lbl_create_comm.Location = new System.Drawing.Point(106, 366);
            this.ec_lbl_create_comm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_create_comm.Name = "ec_lbl_create_comm";
            this.ec_lbl_create_comm.Size = new System.Drawing.Size(74, 21);
            this.ec_lbl_create_comm.TabIndex = 34;
            this.ec_lbl_create_comm.Text = "发表评论";
            // 
            // ec_lbl_Comment
            // 
            this.ec_lbl_Comment.AutoSize = true;
            this.ec_lbl_Comment.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_Comment.Location = new System.Drawing.Point(121, 435);
            this.ec_lbl_Comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_Comment.Name = "ec_lbl_Comment";
            this.ec_lbl_Comment.Size = new System.Drawing.Size(68, 17);
            this.ec_lbl_Comment.TabIndex = 35;
            this.ec_lbl_Comment.Text = "评论内容：";
            // 
            // ec_tbx_comment
            // 
            this.ec_tbx_comment.BackColor = System.Drawing.Color.SkyBlue;
            this.ec_tbx_comment.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ec_tbx_comment.Location = new System.Drawing.Point(195, 435);
            this.ec_tbx_comment.Margin = new System.Windows.Forms.Padding(2);
            this.ec_tbx_comment.Multiline = true;
            this.ec_tbx_comment.Name = "ec_tbx_comment";
            this.ec_tbx_comment.Size = new System.Drawing.Size(350, 132);
            this.ec_tbx_comment.TabIndex = 36;
            // 
            // ec_btn_submit
            // 
            this.ec_btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_submit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_submit.DownBack = null;
            this.ec_btn_submit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_btn_submit.Location = new System.Drawing.Point(124, 597);
            this.ec_btn_submit.MouseBack = null;
            this.ec_btn_submit.Name = "ec_btn_submit";
            this.ec_btn_submit.NormlBack = null;
            this.ec_btn_submit.Size = new System.Drawing.Size(65, 30);
            this.ec_btn_submit.TabIndex = 37;
            this.ec_btn_submit.Text = "提交评论";
            this.ec_btn_submit.UseVisualStyleBackColor = false;
            this.ec_btn_submit.Click += new System.EventHandler(this.ec_btn_submit_Click);
            // 
            // ec_btn_cancel
            // 
            this.ec_btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_cancel.DownBack = null;
            this.ec_btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_btn_cancel.Location = new System.Drawing.Point(206, 597);
            this.ec_btn_cancel.MouseBack = null;
            this.ec_btn_cancel.Name = "ec_btn_cancel";
            this.ec_btn_cancel.NormlBack = null;
            this.ec_btn_cancel.Size = new System.Drawing.Size(65, 30);
            this.ec_btn_cancel.TabIndex = 38;
            this.ec_btn_cancel.Text = "取消";
            this.ec_btn_cancel.UseVisualStyleBackColor = false;
            // 
            // ec_btn_return
            // 
            this.ec_btn_return.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_return.DownBack = null;
            this.ec_btn_return.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_btn_return.Location = new System.Drawing.Point(699, 619);
            this.ec_btn_return.MouseBack = null;
            this.ec_btn_return.Name = "ec_btn_return";
            this.ec_btn_return.NormlBack = null;
            this.ec_btn_return.Size = new System.Drawing.Size(80, 38);
            this.ec_btn_return.TabIndex = 39;
            this.ec_btn_return.Text = "返回";
            this.ec_btn_return.UseVisualStyleBackColor = false;
            this.ec_btn_return.Click += new System.EventHandler(this.ec_btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "评论列表";
            // 
            // Emp_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ec_btn_return);
            this.Controls.Add(this.ec_btn_cancel);
            this.Controls.Add(this.ec_btn_submit);
            this.Controls.Add(this.ec_tbx_comment);
            this.Controls.Add(this.ec_lbl_Comment);
            this.Controls.Add(this.ec_lbl_create_comm);
            this.Controls.Add(this.ec_lbl_user_name);
            this.Controls.Add(this.ec_lbl_userName);
            this.Controls.Add(this.ec_flp_comment);
            this.Name = "Emp_Comment";
            this.Text = "讨论区";
            this.Load += new System.EventHandler(this.Emp_Comment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ec_flp_comment;
        private System.Windows.Forms.Label ec_lbl_userName;
        private System.Windows.Forms.Label ec_lbl_user_name;
        private System.Windows.Forms.Label ec_lbl_create_comm;
        private System.Windows.Forms.Label ec_lbl_Comment;
        private System.Windows.Forms.TextBox ec_tbx_comment;
        private CCWin.SkinControl.SkinButton ec_btn_submit;
        private CCWin.SkinControl.SkinButton ec_btn_cancel;
        private CCWin.SkinControl.SkinButton ec_btn_return;
        private System.Windows.Forms.Label label1;
    }
}