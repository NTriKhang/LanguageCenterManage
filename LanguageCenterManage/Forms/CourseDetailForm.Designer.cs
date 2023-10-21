namespace LanguageCenterManage.Forms
{
    partial class CourseDetailForm
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxLanguageName = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxLanguageId = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.DateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.DateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(38, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(26, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(153, 98);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(241, 22);
            this.textBoxId.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(468, 98);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(615, 98);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(38, 135);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(106, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(42, 171);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(848, 104);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(38, 303);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 24);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Open",
            "Process",
            "Pending",
            "End"});
            this.comboBoxStatus.Location = new System.Drawing.Point(172, 305);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(241, 24);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(38, 360);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(113, 24);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Language Id";
            // 
            // textBoxLanguageName
            // 
            this.textBoxLanguageName.Location = new System.Drawing.Point(626, 307);
            this.textBoxLanguageName.Name = "textBoxLanguageName";
            this.textBoxLanguageName.ReadOnly = true;
            this.textBoxLanguageName.Size = new System.Drawing.Size(264, 22);
            this.textBoxLanguageName.TabIndex = 12;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(468, 305);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(148, 24);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Language Name";
            // 
            // comboBoxLanguageId
            // 
            this.comboBoxLanguageId.FormattingEnabled = true;
            this.comboBoxLanguageId.Location = new System.Drawing.Point(172, 362);
            this.comboBoxLanguageId.Name = "comboBoxLanguageId";
            this.comboBoxLanguageId.Size = new System.Drawing.Size(241, 24);
            this.comboBoxLanguageId.TabIndex = 4;
            this.comboBoxLanguageId.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguageId_SelectedIndexChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(38, 417);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(91, 24);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Date start";
            // 
            // DateStartPicker
            // 
            this.DateStartPicker.Location = new System.Drawing.Point(172, 417);
            this.DateStartPicker.Name = "DateStartPicker";
            this.DateStartPicker.Size = new System.Drawing.Size(241, 22);
            this.DateStartPicker.TabIndex = 6;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(468, 360);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(91, 24);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Date start";
            // 
            // DateEndPicker
            // 
            this.DateEndPicker.Location = new System.Drawing.Point(626, 362);
            this.DateEndPicker.Name = "DateEndPicker";
            this.DateEndPicker.Size = new System.Drawing.Size(264, 22);
            this.DateEndPicker.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Depth = 0;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(42, 484);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Primary = true;
            this.btnCreate.Size = new System.Drawing.Size(85, 36);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(808, 484);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(82, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(693, 484);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(87, 36);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CourseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 532);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.DateEndPicker);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.DateStartPicker);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.comboBoxLanguageId);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.textBoxLanguageName);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CourseDetailForm";
            this.Text = "CourseDetail";
            this.Load += new System.EventHandler(this.CourseDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBoxId;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox textBoxName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox textBoxLanguageName;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox comboBoxLanguageId;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker DateStartPicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DateTimePicker DateEndPicker;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreate;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
    }
}