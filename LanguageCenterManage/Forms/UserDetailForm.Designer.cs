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
            this.txtEmailStudent = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(26, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(134, 270);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(683, 96);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.Text = "";
            // 
            // dtBirth
            // 
            this.dtBirth.CustomFormat = "dd/MM/yyy";
            this.dtBirth.Location = new System.Drawing.Point(134, 201);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(224, 22);
            this.dtBirth.TabIndex = 3;
            this.dtBirth.Value = new System.DateTime(2023, 10, 19, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(566, 146);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(251, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(471, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "LastName";
            // 
            // txtEmailStudent
            // 
            this.txtEmailStudent.Location = new System.Drawing.Point(566, 85);
            this.txtEmailStudent.Multiline = true;
            this.txtEmailStudent.Name = "txtEmailStudent";
            this.txtEmailStudent.Size = new System.Drawing.Size(251, 22);
            this.txtEmailStudent.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(134, 147);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(224, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(471, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "FirstName";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Enabled = false;
            this.txtIdStudent.Location = new System.Drawing.Point(134, 84);
            this.txtIdStudent.Multiline = true;
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(224, 22);
            this.txtIdStudent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(566, 203);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(251, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(471, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(26, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birth";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(26, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Role Id";
            // 
            // roleIdCb
            // 
            this.roleIdCb.FormattingEnabled = true;
            this.roleIdCb.Location = new System.Drawing.Point(134, 428);
            this.roleIdCb.Name = "roleIdCb";
            this.roleIdCb.Size = new System.Drawing.Size(224, 24);
            this.roleIdCb.TabIndex = 6;
            this.roleIdCb.SelectedIndexChanged += new System.EventHandler(this.roleIdCb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(471, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Role name";
            // 
            // roleNameTb
            // 
            this.roleNameTb.Enabled = false;
            this.roleNameTb.Location = new System.Drawing.Point(566, 430);
            this.roleNameTb.Multiline = true;
            this.roleNameTb.Name = "roleNameTb";
            this.roleNameTb.Size = new System.Drawing.Size(251, 22);
            this.roleNameTb.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(26, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Password";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(134, 499);
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
            this.createBtn.Location = new System.Drawing.Point(34, 595);
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
            this.deleteBtn.Location = new System.Drawing.Point(732, 595);
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
            this.updateBtn.Location = new System.Drawing.Point(630, 595);
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
            this.showpasswordBtn.Location = new System.Drawing.Point(134, 524);
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
            this.ChangePasswordBtn.Location = new System.Drawing.Point(134, 595);
            this.ChangePasswordBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Primary = true;
            this.ChangePasswordBtn.Size = new System.Drawing.Size(187, 36);
            this.ChangePasswordBtn.TabIndex = 31;
            this.ChangePasswordBtn.Text = "Change password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 654);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailStudent;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
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
    }
}