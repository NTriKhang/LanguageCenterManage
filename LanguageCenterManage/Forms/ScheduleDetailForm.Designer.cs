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
            this.DeleteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.singleRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.DatesOfWeekCheck = new System.Windows.Forms.CheckedListBox();
            this.shiftCb = new System.Windows.Forms.ComboBox();
            this.ListSection = new System.Windows.Forms.Panel();
            this.ListRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.ListSection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(44, 391);
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
            this.materialLabel2.Location = new System.Drawing.Point(424, 391);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Room name";
            // 
            // roomNameTxt
            // 
            this.roomNameTxt.Location = new System.Drawing.Point(580, 393);
            this.roomNameTxt.Name = "roomNameTxt";
            this.roomNameTxt.ReadOnly = true;
            this.roomNameTxt.Size = new System.Drawing.Size(243, 22);
            this.roomNameTxt.TabIndex = 3;
            // 
            // ClassIdtxt
            // 
            this.ClassIdtxt.AutoSize = true;
            this.ClassIdtxt.Depth = 0;
            this.ClassIdtxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.ClassIdtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassIdtxt.Location = new System.Drawing.Point(44, 475);
            this.ClassIdtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassIdtxt.Name = "ClassIdtxt";
            this.ClassIdtxt.Size = new System.Drawing.Size(78, 24);
            this.ClassIdtxt.TabIndex = 4;
            this.ClassIdtxt.Text = "Class Id";
            // 
            // ClassIdCb
            // 
            this.ClassIdCb.FormattingEnabled = true;
            this.ClassIdCb.Location = new System.Drawing.Point(147, 489);
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
            this.txt.Location = new System.Drawing.Point(424, 475);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(125, 24);
            this.txt.TabIndex = 6;
            this.txt.Text = "Course Name";
            // 
            // CourseNameTxt
            // 
            this.CourseNameTxt.Enabled = false;
            this.CourseNameTxt.Location = new System.Drawing.Point(580, 489);
            this.CourseNameTxt.Name = "CourseNameTxt";
            this.CourseNameTxt.Size = new System.Drawing.Size(243, 22);
            this.CourseNameTxt.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(44, 566);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Teacher Id";
            // 
            // TeacherCb
            // 
            this.TeacherCb.FormattingEnabled = true;
            this.TeacherCb.Location = new System.Drawing.Point(147, 566);
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
            this.materialLabel4.Location = new System.Drawing.Point(424, 564);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 24);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Teacher Name";
            // 
            // TeacherNametxt
            // 
            this.TeacherNametxt.Enabled = false;
            this.TeacherNametxt.Location = new System.Drawing.Point(580, 568);
            this.TeacherNametxt.Name = "TeacherNametxt";
            this.TeacherNametxt.Size = new System.Drawing.Size(243, 22);
            this.TeacherNametxt.TabIndex = 11;
            // 
            // RoomIdTxt
            // 
            this.RoomIdTxt.Location = new System.Drawing.Point(147, 393);
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
            this.ShowRoomBtn.Location = new System.Drawing.Point(47, 328);
            this.ShowRoomBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowRoomBtn.Name = "ShowRoomBtn";
            this.ShowRoomBtn.Primary = true;
            this.ShowRoomBtn.Size = new System.Drawing.Size(136, 36);
            this.ShowRoomBtn.TabIndex = 13;
            this.ShowRoomBtn.Text = "Select room";
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
            this.btnAdd.Location = new System.Drawing.Point(43, 693);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 199);
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
            this.materialLabel5.Location = new System.Drawing.Point(44, 195);
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
            this.materialLabel6.Location = new System.Drawing.Point(43, 253);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(49, 24);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Shift";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Depth = 0;
            this.DeleteBtn.Icon = null;
            this.DeleteBtn.Location = new System.Drawing.Point(656, 693);
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
            this.UpdateBtn.Location = new System.Drawing.Point(759, 693);
            this.UpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Primary = true;
            this.UpdateBtn.Size = new System.Drawing.Size(87, 36);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 22);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(85, 24);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Date End";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(159, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // singleRadio
            // 
            this.singleRadio.AutoSize = true;
            this.singleRadio.Checked = true;
            this.singleRadio.Depth = 0;
            this.singleRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.singleRadio.Location = new System.Drawing.Point(3, 18);
            this.singleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.singleRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.singleRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.singleRadio.Name = "singleRadio";
            this.singleRadio.Ripple = true;
            this.singleRadio.Size = new System.Drawing.Size(78, 30);
            this.singleRadio.TabIndex = 23;
            this.singleRadio.TabStop = true;
            this.singleRadio.Text = "Single";
            this.singleRadio.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 76);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(130, 24);
            this.materialLabel8.TabIndex = 25;
            this.materialLabel8.Text = "Dates of week";
            // 
            // DatesOfWeekCheck
            // 
            this.DatesOfWeekCheck.CheckOnClick = true;
            this.DatesOfWeekCheck.FormattingEnabled = true;
            this.DatesOfWeekCheck.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.DatesOfWeekCheck.Location = new System.Drawing.Point(159, 76);
            this.DatesOfWeekCheck.Name = "DatesOfWeekCheck";
            this.DatesOfWeekCheck.Size = new System.Drawing.Size(243, 72);
            this.DatesOfWeekCheck.TabIndex = 26;
            this.DatesOfWeekCheck.SelectedValueChanged += new System.EventHandler(this.DatesOfWeekCheck_SelectedValueChanged);
            // 
            // shiftCb
            // 
            this.shiftCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftCb.FormattingEnabled = true;
            this.shiftCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.shiftCb.Location = new System.Drawing.Point(147, 253);
            this.shiftCb.Name = "shiftCb";
            this.shiftCb.Size = new System.Drawing.Size(121, 24);
            this.shiftCb.TabIndex = 27;
            this.shiftCb.SelectedValueChanged += new System.EventHandler(this.shiftCb_SelectedValueChanged);
            // 
            // ListSection
            // 
            this.ListSection.Controls.Add(this.materialLabel7);
            this.ListSection.Controls.Add(this.dateTimePicker2);
            this.ListSection.Controls.Add(this.DatesOfWeekCheck);
            this.ListSection.Controls.Add(this.materialLabel8);
            this.ListSection.Location = new System.Drawing.Point(428, 178);
            this.ListSection.Name = "ListSection";
            this.ListSection.Size = new System.Drawing.Size(422, 160);
            this.ListSection.TabIndex = 28;
            // 
            // ListRadio
            // 
            this.ListRadio.AutoSize = true;
            this.ListRadio.Depth = 0;
            this.ListRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.ListRadio.Location = new System.Drawing.Point(3, 50);
            this.ListRadio.Margin = new System.Windows.Forms.Padding(0);
            this.ListRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListRadio.Name = "ListRadio";
            this.ListRadio.Ripple = true;
            this.ListRadio.Size = new System.Drawing.Size(58, 30);
            this.ListRadio.TabIndex = 24;
            this.ListRadio.Text = "List";
            this.ListRadio.UseVisualStyleBackColor = true;
            this.ListRadio.CheckedChanged += new System.EventHandler(this.ListRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.singleRadio);
            this.groupBox1.Controls.Add(this.ListRadio);
            this.groupBox1.Location = new System.Drawing.Point(48, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 84);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(147, 632);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(43, 630);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(62, 24);
            this.materialLabel9.TabIndex = 31;
            this.materialLabel9.Text = "Active";
            // 
            // ScheduleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 766);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListSection);
            this.Controls.Add(this.shiftCb);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
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
            this.ListSection.ResumeLayout(false);
            this.ListSection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialRaisedButton DeleteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialRadioButton singleRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.CheckedListBox DatesOfWeekCheck;
        private System.Windows.Forms.ComboBox shiftCb;
        private System.Windows.Forms.Panel ListSection;
        private MaterialSkin.Controls.MaterialRadioButton ListRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}