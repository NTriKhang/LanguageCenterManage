using LanguageCenterManage.CustomControl;

namespace LanguageCenterManage.Forms
{
    partial class UserDetailForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailStudent = new LanguageCenterManage.CustomControl._TextValid();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new LanguageCenterManage.CustomControl._TextValid();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roleIdCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roleNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.createBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.showpasswordBtn = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChangePasswordBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ImageNameTxt = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.profileImageBox = new System.Windows.Forms.PictureBox();
            this.ExportIDCbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(23, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(131, 458);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(683, 96);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.Text = "";
            // 
            // dtBirth
            // 
            this.dtBirth.CustomFormat = "dd/MM/yyy";
            this.dtBirth.Location = new System.Drawing.Point(575, 312);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(242, 22);
            this.dtBirth.TabIndex = 3;
            this.dtBirth.Value = new System.DateTime(2023, 10, 19, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(575, 257);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(471, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "LastName";
            // 
            // txtEmailStudent
            // 
            this.txtEmailStudent._email = true;
            this.txtEmailStudent._phone = false;
            this.txtEmailStudent.isValid = false;
            this.txtEmailStudent.Location = new System.Drawing.Point(575, 159);
            this.txtEmailStudent.Multiline = true;
            this.txtEmailStudent.Name = "txtEmailStudent";
            this.txtEmailStudent.Size = new System.Drawing.Size(239, 22);
            this.txtEmailStudent.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(575, 207);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(239, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(471, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(471, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "FirstName";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Enabled = false;
            this.txtIdStudent.Location = new System.Drawing.Point(575, 108);
            this.txtIdStudent.Multiline = true;
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(239, 22);
            this.txtIdStudent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(471, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // txtPhone
            // 
            this.txtPhone._email = false;
            this.txtPhone._phone = true;
            this.txtPhone.isValid = false;
            this.txtPhone.Location = new System.Drawing.Point(575, 368);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(471, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(471, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birth";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(26, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Role Id";
            // 
            // roleIdCb
            // 
            this.roleIdCb.FormattingEnabled = true;
            this.roleIdCb.Location = new System.Drawing.Point(134, 577);
            this.roleIdCb.Name = "roleIdCb";
            this.roleIdCb.Size = new System.Drawing.Size(224, 24);
            this.roleIdCb.TabIndex = 6;
            this.roleIdCb.SelectedIndexChanged += new System.EventHandler(this.roleIdCb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(471, 579);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Role name";
            // 
            // roleNameTb
            // 
            this.roleNameTb.Enabled = false;
            this.roleNameTb.Location = new System.Drawing.Point(566, 579);
            this.roleNameTb.Multiline = true;
            this.roleNameTb.Name = "roleNameTb";
            this.roleNameTb.Size = new System.Drawing.Size(251, 22);
            this.roleNameTb.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(26, 647);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Password";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(134, 648);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(224, 22);
            this.passwordTb.TabIndex = 7;
            // 
            // createBtn
            // 
            this.createBtn.AutoSize = true;
            this.createBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createBtn.Depth = 0;
            this.createBtn.Icon = null;
            this.createBtn.Location = new System.Drawing.Point(34, 744);
            this.createBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createBtn.Name = "createBtn";
            this.createBtn.Primary = true;
            this.createBtn.Size = new System.Drawing.Size(85, 36);
            this.createBtn.TabIndex = 27;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.Depth = 0;
            this.deleteBtn.Icon = null;
            this.deleteBtn.Location = new System.Drawing.Point(732, 744);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Primary = true;
            this.deleteBtn.Size = new System.Drawing.Size(82, 36);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSize = true;
            this.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBtn.Depth = 0;
            this.updateBtn.Icon = null;
            this.updateBtn.Location = new System.Drawing.Point(630, 744);
            this.updateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Primary = true;
            this.updateBtn.Size = new System.Drawing.Size(87, 36);
            this.updateBtn.TabIndex = 29;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // showpasswordBtn
            // 
            this.showpasswordBtn.AutoSize = true;
            this.showpasswordBtn.Depth = 0;
            this.showpasswordBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.showpasswordBtn.Location = new System.Drawing.Point(134, 673);
            this.showpasswordBtn.Margin = new System.Windows.Forms.Padding(0);
            this.showpasswordBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.showpasswordBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.showpasswordBtn.Name = "showpasswordBtn";
            this.showpasswordBtn.Ripple = true;
            this.showpasswordBtn.Size = new System.Drawing.Size(151, 30);
            this.showpasswordBtn.TabIndex = 30;
            this.showpasswordBtn.Text = "show password";
            this.showpasswordBtn.UseVisualStyleBackColor = true;
            this.showpasswordBtn.CheckedChanged += new System.EventHandler(this.showpasswordBtn_CheckedChanged_1);
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.AutoSize = true;
            this.ChangePasswordBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangePasswordBtn.Depth = 0;
            this.ChangePasswordBtn.Icon = null;
            this.ChangePasswordBtn.Location = new System.Drawing.Point(134, 744);
            this.ChangePasswordBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Primary = true;
            this.ChangePasswordBtn.Size = new System.Drawing.Size(187, 36);
            this.ChangePasswordBtn.TabIndex = 31;
            this.ChangePasswordBtn.Text = "Change password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // ImageNameTxt
            // 
            this.ImageNameTxt.Location = new System.Drawing.Point(30, 398);
            this.ImageNameTxt.Name = "ImageNameTxt";
            this.ImageNameTxt.Size = new System.Drawing.Size(160, 22);
            this.ImageNameTxt.TabIndex = 34;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(211, 398);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(88, 36);
            this.materialRaisedButton1.TabIndex = 33;
            this.materialRaisedButton1.Text = "Upload";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // profileImageBox
            // 
            this.profileImageBox.Location = new System.Drawing.Point(30, 109);
            this.profileImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileImageBox.Name = "profileImageBox";
            this.profileImageBox.Size = new System.Drawing.Size(269, 263);
            this.profileImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileImageBox.TabIndex = 32;
            this.profileImageBox.TabStop = false;
            // 
            // ExportIDCbtn
            // 
            this.ExportIDCbtn.AutoSize = true;
            this.ExportIDCbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportIDCbtn.Depth = 0;
            this.ExportIDCbtn.Icon = null;
            this.ExportIDCbtn.Location = new System.Drawing.Point(496, 744);
            this.ExportIDCbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportIDCbtn.Name = "ExportIDCbtn";
            this.ExportIDCbtn.Primary = true;
            this.ExportIDCbtn.Size = new System.Drawing.Size(118, 36);
            this.ExportIDCbtn.TabIndex = 35;
            this.ExportIDCbtn.Text = "Export IDC";
            this.ExportIDCbtn.UseVisualStyleBackColor = true;
            this.ExportIDCbtn.Click += new System.EventHandler(this.ExportIDCbtn_Click);
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 801);
            this.Controls.Add(this.ExportIDCbtn);
            this.Controls.Add(this.ImageNameTxt);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.profileImageBox);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.showpasswordBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.roleNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roleIdCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailStudent);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "UserDetailForm";
            this.Text = "UserDetailForm";
            this.Load += new System.EventHandler(this.UserDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox roleIdCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roleNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passwordTb;
        private MaterialSkin.Controls.MaterialRaisedButton createBtn;
        private MaterialSkin.Controls.MaterialRaisedButton deleteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton updateBtn;
        private MaterialSkin.Controls.MaterialCheckBox showpasswordBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ChangePasswordBtn;
        private System.Windows.Forms.TextBox ImageNameTxt;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox profileImageBox;
        private MaterialSkin.Controls.MaterialRaisedButton ExportIDCbtn;
        private _TextValid txtEmailStudent;
        private _TextValid txtPhone;
    }
}