namespace WindowsFormsApplication1
{
    partial class PeopleChoose
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
            this.fLP_people = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tBx_findkeywords = new System.Windows.Forms.TextBox();
            this.cBx_allSelect = new System.Windows.Forms.CheckBox();
            this.cBx_workerEntryYear = new CCWin.SkinControl.SkinComboBox();
            this.cBx_workerEntryMonth = new CCWin.SkinControl.SkinComboBox();
            this.cBx_workertype = new CCWin.SkinControl.SkinComboBox();
            this.cbB_findKey = new CCWin.SkinControl.SkinComboBox();
            this.btn_find = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.btn_oK = new CCWin.SkinControl.SkinButton();
            this.pc_btn_return = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // fLP_people
            // 
            this.fLP_people.AutoScroll = true;
            this.fLP_people.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLP_people.Location = new System.Drawing.Point(86, 146);
            this.fLP_people.Margin = new System.Windows.Forms.Padding(4);
            this.fLP_people.Name = "fLP_people";
            this.fLP_people.Size = new System.Drawing.Size(570, 308);
            this.fLP_people.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(74, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "请您输入关键字：";
            // 
            // tBx_findkeywords
            // 
            this.tBx_findkeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tBx_findkeywords.Location = new System.Drawing.Point(213, 70);
            this.tBx_findkeywords.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_findkeywords.Name = "tBx_findkeywords";
            this.tBx_findkeywords.Size = new System.Drawing.Size(220, 29);
            this.tBx_findkeywords.TabIndex = 12;
            // 
            // cBx_allSelect
            // 
            this.cBx_allSelect.AutoSize = true;
            this.cBx_allSelect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cBx_allSelect.Location = new System.Drawing.Point(86, 459);
            this.cBx_allSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cBx_allSelect.Name = "cBx_allSelect";
            this.cBx_allSelect.Size = new System.Drawing.Size(61, 25);
            this.cBx_allSelect.TabIndex = 18;
            this.cBx_allSelect.Text = "全选";
            this.cBx_allSelect.UseVisualStyleBackColor = true;
            this.cBx_allSelect.CheckedChanged += new System.EventHandler(this.cBx_allSelect_CheckedChanged);
            // 
            // cBx_workerEntryYear
            // 
            this.cBx_workerEntryYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_workerEntryYear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_workerEntryYear.FormattingEnabled = true;
            this.cBx_workerEntryYear.Location = new System.Drawing.Point(213, 15);
            this.cBx_workerEntryYear.Name = "cBx_workerEntryYear";
            this.cBx_workerEntryYear.Size = new System.Drawing.Size(220, 24);
            this.cBx_workerEntryYear.TabIndex = 21;
            this.cBx_workerEntryYear.WaterText = "";
            // 
            // cBx_workerEntryMonth
            // 
            this.cBx_workerEntryMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_workerEntryMonth.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_workerEntryMonth.FormattingEnabled = true;
            this.cBx_workerEntryMonth.Location = new System.Drawing.Point(213, 43);
            this.cBx_workerEntryMonth.Name = "cBx_workerEntryMonth";
            this.cBx_workerEntryMonth.Size = new System.Drawing.Size(220, 24);
            this.cBx_workerEntryMonth.TabIndex = 22;
            this.cBx_workerEntryMonth.WaterText = "";
            // 
            // cBx_workertype
            // 
            this.cBx_workertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_workertype.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_workertype.FormattingEnabled = true;
            this.cBx_workertype.Location = new System.Drawing.Point(213, 101);
            this.cBx_workertype.Name = "cBx_workertype";
            this.cBx_workertype.Size = new System.Drawing.Size(220, 24);
            this.cBx_workertype.TabIndex = 23;
            this.cBx_workertype.WaterText = "";
            // 
            // cbB_findKey
            // 
            this.cbB_findKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbB_findKey.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbB_findKey.FormattingEnabled = true;
            this.cbB_findKey.Location = new System.Drawing.Point(439, 72);
            this.cbB_findKey.Name = "cbB_findKey";
            this.cbB_findKey.Size = new System.Drawing.Size(112, 24);
            this.cbB_findKey.TabIndex = 24;
            this.cbB_findKey.WaterText = "";
            this.cbB_findKey.SelectedIndexChanged += new System.EventHandler(this.cbB_findKey_SelectedIndexChanged);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_find.DownBack = null;
            this.btn_find.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_find.Location = new System.Drawing.Point(557, 70);
            this.btn_find.MouseBack = null;
            this.btn_find.Name = "btn_find";
            this.btn_find.NormlBack = null;
            this.btn_find.Size = new System.Drawing.Size(56, 30);
            this.btn_find.TabIndex = 25;
            this.btn_find.Text = "查询";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_cancel.Location = new System.Drawing.Point(619, 71);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(56, 30);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_oK
            // 
            this.btn_oK.BackColor = System.Drawing.Color.Transparent;
            this.btn_oK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_oK.DownBack = null;
            this.btn_oK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_oK.Location = new System.Drawing.Point(522, 508);
            this.btn_oK.MouseBack = null;
            this.btn_oK.Name = "btn_oK";
            this.btn_oK.NormlBack = null;
            this.btn_oK.Size = new System.Drawing.Size(91, 37);
            this.btn_oK.TabIndex = 27;
            this.btn_oK.Text = "确定";
            this.btn_oK.UseVisualStyleBackColor = false;
            this.btn_oK.Click += new System.EventHandler(this.btn_oK_Click);
            // 
            // pc_btn_return
            // 
            this.pc_btn_return.BackColor = System.Drawing.Color.Transparent;
            this.pc_btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pc_btn_return.DownBack = null;
            this.pc_btn_return.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pc_btn_return.Location = new System.Drawing.Point(631, 508);
            this.pc_btn_return.MouseBack = null;
            this.pc_btn_return.Name = "pc_btn_return";
            this.pc_btn_return.NormlBack = null;
            this.pc_btn_return.Size = new System.Drawing.Size(91, 37);
            this.pc_btn_return.TabIndex = 28;
            this.pc_btn_return.Text = "返回";
            this.pc_btn_return.UseVisualStyleBackColor = false;
            this.pc_btn_return.Click += new System.EventHandler(this.pc_btn_return_Click);
            // 
            // PeopleChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.pc_btn_return);
            this.Controls.Add(this.btn_oK);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.cbB_findKey);
            this.Controls.Add(this.cBx_workertype);
            this.Controls.Add(this.cBx_workerEntryMonth);
            this.Controls.Add(this.cBx_workerEntryYear);
            this.Controls.Add(this.cBx_allSelect);
            this.Controls.Add(this.fLP_people);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBx_findkeywords);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PeopleChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工选择";
            this.Load += new System.EventHandler(this.PeopleChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fLP_people;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBx_findkeywords;
        private System.Windows.Forms.CheckBox cBx_allSelect;
        private CCWin.SkinControl.SkinComboBox cBx_workerEntryYear;
        private CCWin.SkinControl.SkinComboBox cBx_workerEntryMonth;
        private CCWin.SkinControl.SkinComboBox cBx_workertype;
        private CCWin.SkinControl.SkinComboBox cbB_findKey;
        private CCWin.SkinControl.SkinButton btn_find;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private CCWin.SkinControl.SkinButton btn_oK;
        private CCWin.SkinControl.SkinButton pc_btn_return;
    }
}