namespace LanguageCenterManage.Forms
{
    partial class ScheduleDetailForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.roomNameTxt = new System.Windows.Forms.TextBox();
            this.ClassIdtxt = new MaterialSkin.Controls.MaterialLabel();
            this.ClassIdCb = new System.Windows.Forms.ComboBox();
            this.txt = new MaterialSkin.Controls.MaterialLabel();
            this.CourseNameTxt = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TeacherCb = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TeacherNametxt = new System.Windows.Forms.TextBox();
            this.RoomIdTxt = new System.Windows.Forms.TextBox();
            this.ShowRoomBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.ShiftTxt = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(45, 226);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Room Id";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(369, 226);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Room name";
            // 
            // roomNameTxt
            // 
            this.roomNameTxt.Location = new System.Drawing.Point(373, 264);
            this.roomNameTxt.Name = "roomNameTxt";
            this.roomNameTxt.ReadOnly = true;
            this.roomNameTxt.Size = new System.Drawing.Size(198, 22);
            this.roomNameTxt.TabIndex = 3;
            // 
            // ClassIdtxt
            // 
            this.ClassIdtxt.AutoSize = true;
            this.ClassIdtxt.Depth = 0;
            this.ClassIdtxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.ClassIdtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassIdtxt.Location = new System.Drawing.Point(45, 310);
            this.ClassIdtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassIdtxt.Name = "ClassIdtxt";
            this.ClassIdtxt.Size = new System.Drawing.Size(78, 24);
            this.ClassIdtxt.TabIndex = 4;
            this.ClassIdtxt.Text = "Class Id";
            // 
            // ClassIdCb
            // 
            this.ClassIdCb.FormattingEnabled = true;
            this.ClassIdCb.Location = new System.Drawing.Point(49, 352);
            this.ClassIdCb.Name = "ClassIdCb";
            this.ClassIdCb.Size = new System.Drawing.Size(243, 24);
            this.ClassIdCb.TabIndex = 5;
            this.ClassIdCb.DropDown += new System.EventHandler(this.ClassIdCb_DropDown);
            this.ClassIdCb.SelectedIndexChanged += new System.EventHandler(this.ClassIdCb_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Depth = 0;
            this.txt.Font = new System.Drawing.Font("Roboto", 11F);
            this.txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt.Location = new System.Drawing.Point(369, 310);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(125, 24);
            this.txt.TabIndex = 6;
            this.txt.Text = "Course Name";
            // 
            // CourseNameTxt
            // 
            this.CourseNameTxt.Enabled = false;
            this.CourseNameTxt.Location = new System.Drawing.Point(373, 354);
            this.CourseNameTxt.Name = "CourseNameTxt";
            this.CourseNameTxt.Size = new System.Drawing.Size(198, 22);
            this.CourseNameTxt.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(45, 401);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Teacher Id";
            // 
            // TeacherCb
            // 
            this.TeacherCb.FormattingEnabled = true;
            this.TeacherCb.Location = new System.Drawing.Point(49, 442);
            this.TeacherCb.Name = "TeacherCb";
            this.TeacherCb.Size = new System.Drawing.Size(243, 24);
            this.TeacherCb.TabIndex = 9;
            this.TeacherCb.SelectedIndexChanged += new System.EventHandler(this.TeacherCb_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(369, 401);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 24);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Teacher Name";
            // 
            // TeacherNametxt
            // 
            this.TeacherNametxt.Enabled = false;
            this.TeacherNametxt.Location = new System.Drawing.Point(373, 444);
            this.TeacherNametxt.Name = "TeacherNametxt";
            this.TeacherNametxt.Size = new System.Drawing.Size(198, 22);
            this.TeacherNametxt.TabIndex = 11;
            // 
            // RoomIdTxt
            // 
            this.RoomIdTxt.Location = new System.Drawing.Point(49, 264);
            this.RoomIdTxt.Name = "RoomIdTxt";
            this.RoomIdTxt.ReadOnly = true;
            this.RoomIdTxt.Size = new System.Drawing.Size(243, 22);
            this.RoomIdTxt.TabIndex = 12;
            // 
            // ShowRoomBtn
            // 
            this.ShowRoomBtn.AutoSize = true;
            this.ShowRoomBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowRoomBtn.Depth = 0;
            this.ShowRoomBtn.Icon = null;
            this.ShowRoomBtn.Location = new System.Drawing.Point(49, 168);
            this.ShowRoomBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowRoomBtn.Name = "ShowRoomBtn";
            this.ShowRoomBtn.Primary = true;
            this.ShowRoomBtn.Size = new System.Drawing.Size(219, 36);
            this.ShowRoomBtn.TabIndex = 13;
            this.ShowRoomBtn.Text = "Show available room";
            this.ShowRoomBtn.UseVisualStyleBackColor = true;
            this.ShowRoomBtn.Click += new System.EventHandler(this.ShowRoomBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(49, 504);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(56, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(45, 83);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 24);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Date";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(369, 83);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(49, 24);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Shift";
            // 
            // ShiftTxt
            // 
            this.ShiftTxt.Location = new System.Drawing.Point(368, 127);
            this.ShiftTxt.Name = "ShiftTxt";
            this.ShiftTxt.Size = new System.Drawing.Size(53, 22);
            this.ShiftTxt.TabIndex = 18;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Depth = 0;
            this.DeleteBtn.Icon = null;
            this.DeleteBtn.Location = new System.Drawing.Point(662, 504);
            this.DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Primary = true;
            this.DeleteBtn.Size = new System.Drawing.Size(82, 36);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AutoSize = true;
            this.UpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Depth = 0;
            this.UpdateBtn.Icon = null;
            this.UpdateBtn.Location = new System.Drawing.Point(765, 504);
            this.UpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Primary = true;
            this.UpdateBtn.Size = new System.Drawing.Size(87, 36);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ScheduleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 552);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ShiftTxt);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ShowRoomBtn);
            this.Controls.Add(this.RoomIdTxt);
            this.Controls.Add(this.TeacherNametxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TeacherCb);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.CourseNameTxt);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.ClassIdCb);
            this.Controls.Add(this.ClassIdtxt);
            this.Controls.Add(this.roomNameTxt);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ScheduleDetailForm";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ScheduleDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox roomNameTxt;
        private MaterialSkin.Controls.MaterialLabel ClassIdtxt;
        private System.Windows.Forms.ComboBox ClassIdCb;
        private MaterialSkin.Controls.MaterialLabel txt;
        private System.Windows.Forms.TextBox CourseNameTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox TeacherCb;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox TeacherNametxt;
        private System.Windows.Forms.TextBox RoomIdTxt;
        private MaterialSkin.Controls.MaterialRaisedButton ShowRoomBtn;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox ShiftTxt;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateBtn;
    }
}