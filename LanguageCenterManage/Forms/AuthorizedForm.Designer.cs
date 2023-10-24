namespace LanguageCenterManage.Forms
{
    partial class AuthorizedForm
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
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.SendAgainBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ConfirmBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // codeTextbox
            // 
            this.codeTextbox.Location = new System.Drawing.Point(58, 153);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(286, 22);
            this.codeTextbox.TabIndex = 0;
            // 
            // SendAgainBtn
            // 
            this.SendAgainBtn.AutoSize = true;
            this.SendAgainBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendAgainBtn.Depth = 0;
            this.SendAgainBtn.Icon = null;
            this.SendAgainBtn.Location = new System.Drawing.Point(223, 199);
            this.SendAgainBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendAgainBtn.Name = "SendAgainBtn";
            this.SendAgainBtn.Primary = true;
            this.SendAgainBtn.Size = new System.Drawing.Size(121, 36);
            this.SendAgainBtn.TabIndex = 1;
            this.SendAgainBtn.Text = "Send again";
            this.SendAgainBtn.UseVisualStyleBackColor = true;
            this.SendAgainBtn.Click += new System.EventHandler(this.SendAgainBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmBtn.Depth = 0;
            this.ConfirmBtn.Icon = null;
            this.ConfirmBtn.Location = new System.Drawing.Point(58, 289);
            this.ConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Primary = true;
            this.ConfirmBtn.Size = new System.Drawing.Size(286, 36);
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // AuthorizedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 407);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.SendAgainBtn);
            this.Controls.Add(this.codeTextbox);
            this.Name = "AuthorizedForm";
            this.Text = "AuthorizedForm";
            this.Load += new System.EventHandler(this.AuthorizedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextbox;
        private MaterialSkin.Controls.MaterialRaisedButton SendAgainBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ConfirmBtn;
    }
}