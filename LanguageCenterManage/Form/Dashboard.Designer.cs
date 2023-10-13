namespace LanguageCenterManage
{
    partial class Dashboard
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
            this.Navbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.Navbar.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Navbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Navbar.Controls.Add(this.label1);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1172, 120);
            this.Navbar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Học Viên Ở Trung Tâm Ngoại Ngữ";
            // 
            // Sidebar
            // 
            this.Sidebar.Controls.Add(this.panel4);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 120);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(638, 465);
            this.Sidebar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 465);
            this.panel4.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(638, 120);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(534, 465);
            this.Content.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 585);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Navbar);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Navbar;
        public System.Windows.Forms.Panel Sidebar;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel Content;
        public System.Windows.Forms.Label label1;
    }
}

