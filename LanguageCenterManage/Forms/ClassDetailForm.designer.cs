namespace LanguageCenterManage.Forms
{
    partial class ClassDetailForm
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
            this.Idtextbox = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.quanlityTextbox = new System.Windows.Forms.TextBox();
            this.CourseIdCB = new System.Windows.Forms.ComboBox();
            this.createBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(26, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Id";
            // 
            // Idtextbox
            // 
            this.Idtextbox.Enabled = false;
            this.Idtextbox.Location = new System.Drawing.Point(199, 96);
            this.Idtextbox.Name = "Idtextbox";
            this.Idtextbox.Size = new System.Drawing.Size(186, 22);
            this.Idtextbox.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(440, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(125, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Course Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(41, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Course Id";
            // 
            // CourseName
            // 
            this.CourseName.Enabled = false;
            this.CourseName.Location = new System.Drawing.Point(594, 159);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(186, 22);
            this.CourseName.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(440, 94);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(78, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Quanlity";
            // 
            // quanlityTextbox
            // 
            this.quanlityTextbox.Location = new System.Drawing.Point(594, 94);
            this.quanlityTextbox.Name = "quanlityTextbox";
            this.quanlityTextbox.Size = new System.Drawing.Size(186, 22);
            this.quanlityTextbox.TabIndex = 0;
            // 
            // CourseIdCB
            // 
            this.CourseIdCB.FormattingEnabled = true;
            this.CourseIdCB.Location = new System.Drawing.Point(199, 157);
            this.CourseIdCB.Name = "CourseIdCB";
            this.CourseIdCB.Size = new System.Drawing.Size(186, 24);
            this.CourseIdCB.TabIndex = 1;
            this.CourseIdCB.SelectedIndexChanged += new System.EventHandler(this.CourseIdCB_SelectedIndexChanged);
            // 
            // createBtn
            // 
            this.createBtn.AutoSize = true;
            this.createBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createBtn.Depth = 0;
            this.createBtn.Icon = null;
            this.createBtn.Location = new System.Drawing.Point(45, 293);
            this.createBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createBtn.Name = "createBtn";
            this.createBtn.Primary = true;
            this.createBtn.Size = new System.Drawing.Size(85, 36);
            this.createBtn.TabIndex = 9;
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
            this.deleteBtn.Location = new System.Drawing.Point(695, 293);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Primary = true;
            this.deleteBtn.Size = new System.Drawing.Size(82, 36);
            this.deleteBtn.TabIndex = 10;
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
            this.updateBtn.Location = new System.Drawing.Point(594, 293);
            this.updateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Primary = true;
            this.updateBtn.Size = new System.Drawing.Size(87, 36);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ClassDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 352);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.CourseIdCB);
            this.Controls.Add(this.quanlityTextbox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Idtextbox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ClassDetailForm";
            this.Text = "ClassDetailForm";
            this.Load += new System.EventHandler(this.ClassDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox Idtextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox CourseName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox quanlityTextbox;
        private System.Windows.Forms.ComboBox CourseIdCB;
        private MaterialSkin.Controls.MaterialRaisedButton createBtn;
        private MaterialSkin.Controls.MaterialRaisedButton deleteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton updateBtn;
    }
}