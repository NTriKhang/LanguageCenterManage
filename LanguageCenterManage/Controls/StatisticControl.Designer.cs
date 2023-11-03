namespace LanguageCenterManage.Controls
{
    partial class StatisticControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KmeanBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // KmeanBtn
            // 
            this.KmeanBtn.AutoSize = true;
            this.KmeanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KmeanBtn.Depth = 0;
            this.KmeanBtn.Icon = null;
            this.KmeanBtn.Location = new System.Drawing.Point(622, 119);
            this.KmeanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.KmeanBtn.Name = "KmeanBtn";
            this.KmeanBtn.Primary = true;
            this.KmeanBtn.Size = new System.Drawing.Size(193, 36);
            this.KmeanBtn.TabIndex = 0;
            this.KmeanBtn.Text = "K-mean clustering";
            this.KmeanBtn.UseVisualStyleBackColor = true;
            this.KmeanBtn.Click += new System.EventHandler(this.KmeanBtn_Click);
            // 
            // StatisticControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KmeanBtn);
            this.Name = "StatisticControl";
            this.Size = new System.Drawing.Size(1544, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton KmeanBtn;
    }
}
