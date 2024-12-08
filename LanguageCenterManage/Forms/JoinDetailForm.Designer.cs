namespace LanguageCenterManage.Forms
{
    partial class JoinDetailForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtSecondGrade = new System.Windows.Forms.TextBox();
            this.txtFistGrade = new System.Windows.Forms.TextBox();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.btnShowListClass = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJoinId = new System.Windows.Forms.TextBox();
            this.btnBill = new MaterialSkin.Controls.MaterialRaisedButton();
            this.classDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.StatusTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.classDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(486, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 36);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(408, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "SudentId";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "FirstGrade";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(408, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "SecondGrade";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(14, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "FinalGrade";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Location = new System.Drawing.Point(525, 93);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(194, 22);
            this.txtStudentId.TabIndex = 33;
            // 
            // txtSecondGrade
            // 
            this.txtSecondGrade.Location = new System.Drawing.Point(525, 131);
            this.txtSecondGrade.Name = "txtSecondGrade";
            this.txtSecondGrade.Size = new System.Drawing.Size(194, 22);
            this.txtSecondGrade.TabIndex = 33;
            // 
            // txtFistGrade
            // 
            this.txtFistGrade.Location = new System.Drawing.Point(115, 131);
            this.txtFistGrade.Name = "txtFistGrade";
            this.txtFistGrade.Size = new System.Drawing.Size(194, 22);
            this.txtFistGrade.TabIndex = 33;
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(115, 169);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(194, 22);
            this.txtFinalGrade.TabIndex = 33;
            this.txtFinalGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinalGrade_KeyPress);
            // 
            // btnShowListClass
            // 
            this.btnShowListClass.AutoSize = true;
            this.btnShowListClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowListClass.Depth = 0;
            this.btnShowListClass.Icon = null;
            this.btnShowListClass.Location = new System.Drawing.Point(199, 207);
            this.btnShowListClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowListClass.Name = "btnShowListClass";
            this.btnShowListClass.Primary = true;
            this.btnShowListClass.Size = new System.Drawing.Size(110, 36);
            this.btnShowListClass.TabIndex = 35;
            this.btnShowListClass.Text = "ListClass";
            this.btnShowListClass.UseVisualStyleBackColor = true;
            this.btnShowListClass.Click += new System.EventHandler(this.btnShowListClass_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(408, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "ClassId";
            // 
            // txtClassId
            // 
            this.txtClassId.Enabled = false;
            this.txtClassId.Location = new System.Drawing.Point(525, 169);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(194, 22);
            this.txtClassId.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(371, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 36);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(601, 261);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(56, 36);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Id";
            // 
            // txtJoinId
            // 
            this.txtJoinId.Enabled = false;
            this.txtJoinId.Location = new System.Drawing.Point(115, 93);
            this.txtJoinId.Name = "txtJoinId";
            this.txtJoinId.Size = new System.Drawing.Size(194, 22);
            this.txtJoinId.TabIndex = 33;
            // 
            // btnBill
            // 
            this.btnBill.AutoSize = true;
            this.btnBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBill.Depth = 0;
            this.btnBill.Icon = null;
            this.btnBill.Location = new System.Drawing.Point(663, 261);
            this.btnBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBill.Name = "btnBill";
            this.btnBill.Primary = true;
            this.btnBill.Size = new System.Drawing.Size(56, 36);
            this.btnBill.TabIndex = 35;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // classDTOBindingSource
            // 
            this.classDTOBindingSource.DataSource = typeof(LanguageCenterManage.DTO.ClassDTO);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(408, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Status";
            // 
            // StatusTxt
            // 
            this.StatusTxt.FormattingEnabled = true;
            this.StatusTxt.Items.AddRange(new object[] {
            "Process",
            "Pass",
            "Fail"});
            this.StatusTxt.Location = new System.Drawing.Point(525, 214);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(194, 24);
            this.StatusTxt.TabIndex = 40;
            // 
            // JoinDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 328);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnShowListClass);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.txtSecondGrade);
            this.Controls.Add(this.txtFinalGrade);
            this.Controls.Add(this.txtFistGrade);
            this.Controls.Add(this.txtJoinId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "JoinDetailForm";
            this.Text = "Join Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JoinDetailForm_FormClosed);
            this.Load += new System.EventHandler(this.JoinDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtSecondGrade;
        private System.Windows.Forms.TextBox txtFistGrade;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowListClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.BindingSource classDTOBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJoinId;
        private MaterialSkin.Controls.MaterialRaisedButton btnBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StatusTxt;
    }
}