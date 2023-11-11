﻿namespace LanguageCenterManage.Forms
{
    partial class BillDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.PanelBill = new System.Windows.Forms.Panel();
            this.txtCourseName = new System.Windows.Forms.Label();
            this.txtUserConfirmName = new System.Windows.Forms.Label();
            this.txtDatePay = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.Label();
            this.txtUserConfirmId = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxState = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.PanelBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelBill);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 545);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(272, 442);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 44);
            this.btnExport.TabIndex = 64;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(400, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 44);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(531, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 44);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PanelBill
            // 
            this.PanelBill.Controls.Add(this.txtCourseName);
            this.PanelBill.Controls.Add(this.txtUserConfirmName);
            this.PanelBill.Controls.Add(this.txtDatePay);
            this.PanelBill.Controls.Add(this.txtStudentName);
            this.PanelBill.Controls.Add(this.txtCost);
            this.PanelBill.Controls.Add(this.txtUserConfirmId);
            this.PanelBill.Controls.Add(this.txtBillId);
            this.PanelBill.Controls.Add(this.label2);
            this.PanelBill.Controls.Add(this.CheckBoxState);
            this.PanelBill.Controls.Add(this.label5);
            this.PanelBill.Controls.Add(this.labelConfirm);
            this.PanelBill.Controls.Add(this.label4);
            this.PanelBill.Controls.Add(this.labelCost);
            this.PanelBill.Controls.Add(this.label6);
            this.PanelBill.Controls.Add(this.label3);
            this.PanelBill.Controls.Add(this.label1);
            this.PanelBill.Location = new System.Drawing.Point(31, 12);
            this.PanelBill.Name = "PanelBill";
            this.PanelBill.Size = new System.Drawing.Size(674, 411);
            this.PanelBill.TabIndex = 65;
            this.PanelBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBill_MouseDown);
            // 
            // txtCourseName
            // 
            this.txtCourseName.AutoSize = true;
            this.txtCourseName.Location = new System.Drawing.Point(555, 300);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(57, 16);
            this.txtCourseName.TabIndex = 85;
            this.txtCourseName.Text = "2/7/2003";
            // 
            // txtUserConfirmName
            // 
            this.txtUserConfirmName.AutoSize = true;
            this.txtUserConfirmName.Location = new System.Drawing.Point(555, 221);
            this.txtUserConfirmName.Name = "txtUserConfirmName";
            this.txtUserConfirmName.Size = new System.Drawing.Size(63, 16);
            this.txtUserConfirmName.TabIndex = 86;
            this.txtUserConfirmName.Text = "Cao Hieu";
            // 
            // txtDatePay
            // 
            this.txtDatePay.AutoSize = true;
            this.txtDatePay.Location = new System.Drawing.Point(549, 144);
            this.txtDatePay.Name = "txtDatePay";
            this.txtDatePay.Size = new System.Drawing.Size(57, 16);
            this.txtDatePay.TabIndex = 87;
            this.txtDatePay.Text = "2/7/2003";
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.Location = new System.Drawing.Point(198, 362);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(56, 16);
            this.txtStudentName.TabIndex = 88;
            this.txtStudentName.Text = "inei2n23";
            // 
            // txtCost
            // 
            this.txtCost.AutoSize = true;
            this.txtCost.Location = new System.Drawing.Point(195, 300);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(56, 16);
            this.txtCost.TabIndex = 89;
            this.txtCost.Text = "inei2n23";
            // 
            // txtUserConfirmId
            // 
            this.txtUserConfirmId.AutoSize = true;
            this.txtUserConfirmId.Location = new System.Drawing.Point(195, 221);
            this.txtUserConfirmId.Name = "txtUserConfirmId";
            this.txtUserConfirmId.Size = new System.Drawing.Size(56, 16);
            this.txtUserConfirmId.TabIndex = 90;
            this.txtUserConfirmId.Text = "inei2n23";
            // 
            // txtBillId
            // 
            this.txtBillId.AutoSize = true;
            this.txtBillId.Location = new System.Drawing.Point(198, 149);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(53, 16);
            this.txtBillId.TabIndex = 91;
            this.txtBillId.Text = "sadasd";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 61);
            this.label2.TabIndex = 84;
            this.label2.Text = "Bill Detail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxState
            // 
            this.CheckBoxState.AutoSize = true;
            this.CheckBoxState.Location = new System.Drawing.Point(546, 362);
            this.CheckBoxState.Name = "CheckBoxState";
            this.CheckBoxState.Size = new System.Drawing.Size(60, 20);
            this.CheckBoxState.TabIndex = 83;
            this.CheckBoxState.Text = "State";
            this.CheckBoxState.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(395, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 81;
            this.label5.Text = "CourseName:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelConfirm
            // 
            this.labelConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConfirm.Location = new System.Drawing.Point(366, 218);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(161, 23);
            this.labelConfirm.TabIndex = 76;
            this.labelConfirm.Text = "UserConfirmName:";
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(56, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "StudentName:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCost
            // 
            this.labelCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCost.Location = new System.Drawing.Point(56, 296);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(72, 23);
            this.labelCost.TabIndex = 79;
            this.labelCost.Text = "Cost:";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(56, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 78;
            this.label6.Text = "Id:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(56, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 82;
            this.label3.Text = "UserConfirmId:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(395, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "DatePay:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classDTOBindingSource
            // 
            this.classDTOBindingSource.DataSource = typeof(LanguageCenterManage.DTO.ClassDTO);
            // 
            // BillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 545);
            this.Controls.Add(this.panel1);
            this.Name = "BillDetail";
            this.Text = "BillDetail";
            this.Load += new System.EventHandler(this.BillDetail_Load);
            this.panel1.ResumeLayout(false);
            this.PanelBill.ResumeLayout(false);
            this.PanelBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource classDTOBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel PanelBill;
        private System.Windows.Forms.Label txtCourseName;
        private System.Windows.Forms.Label txtUserConfirmName;
        private System.Windows.Forms.Label txtDatePay;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.Label txtCost;
        private System.Windows.Forms.Label txtUserConfirmId;
        private System.Windows.Forms.Label txtBillId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}