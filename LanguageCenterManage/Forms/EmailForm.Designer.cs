namespace LanguageCenterManage.Forms
{
    partial class EmailForm
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
            this.SubjectTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.bodyTextbox = new System.Windows.Forms.RichTextBox();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // SubjectTB
            // 
            this.SubjectTB.Depth = 0;
            this.SubjectTB.Hint = "";
            this.SubjectTB.Location = new System.Drawing.Point(31, 120);
            this.SubjectTB.MaxLength = 32767;
            this.SubjectTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubjectTB.Name = "SubjectTB";
            this.SubjectTB.PasswordChar = '\0';
            this.SubjectTB.SelectedText = "";
            this.SubjectTB.SelectionLength = 0;
            this.SubjectTB.SelectionStart = 0;
            this.SubjectTB.Size = new System.Drawing.Size(691, 28);
            this.SubjectTB.TabIndex = 0;
            this.SubjectTB.TabStop = false;
            this.SubjectTB.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Subject";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(31, 167);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Body";
            // 
            // bodyTextbox
            // 
            this.bodyTextbox.Location = new System.Drawing.Point(35, 210);
            this.bodyTextbox.Name = "bodyTextbox";
            this.bodyTextbox.Size = new System.Drawing.Size(687, 145);
            this.bodyTextbox.TabIndex = 3;
            this.bodyTextbox.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(656, 402);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(66, 36);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.bodyTextbox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.SubjectTB);
            this.Name = "EmailForm";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField SubjectTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox bodyTextbox;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
    }
}