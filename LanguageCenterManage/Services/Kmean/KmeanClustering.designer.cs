namespace LanguageCenterManage.Services.Kmean
{
    partial class KmeanForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInitializeCluster = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignDataPointsToCloserCluster = new System.Windows.Forms.Button();
            this.btnCalculateCenterOfEachCluster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SihoutteRadio = new System.Windows.Forms.RadioButton();
            this.elbowRadio = new System.Windows.Forms.RadioButton();
            this.tfNumberOfCluster = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindTheResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.YearCb = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1139, 192);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 28);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInitializeCluster
            // 
            this.btnInitializeCluster.Location = new System.Drawing.Point(1139, 228);
            this.btnInitializeCluster.Margin = new System.Windows.Forms.Padding(4);
            this.btnInitializeCluster.Name = "btnInitializeCluster";
            this.btnInitializeCluster.Size = new System.Drawing.Size(168, 28);
            this.btnInitializeCluster.TabIndex = 1;
            this.btnInitializeCluster.Text = "Initialize Cluster";
            this.btnInitializeCluster.UseVisualStyleBackColor = true;
            this.btnInitializeCluster.Click += new System.EventHandler(this.btnInitializeCluster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1109, 772);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAssignDataPointsToCloserCluster
            // 
            this.btnAssignDataPointsToCloserCluster.Location = new System.Drawing.Point(1137, 372);
            this.btnAssignDataPointsToCloserCluster.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssignDataPointsToCloserCluster.Name = "btnAssignDataPointsToCloserCluster";
            this.btnAssignDataPointsToCloserCluster.Size = new System.Drawing.Size(244, 28);
            this.btnAssignDataPointsToCloserCluster.TabIndex = 3;
            this.btnAssignDataPointsToCloserCluster.Text = "Assign data points to closer cluster";
            this.btnAssignDataPointsToCloserCluster.UseVisualStyleBackColor = true;
            this.btnAssignDataPointsToCloserCluster.Click += new System.EventHandler(this.btnIterate_Click);
            // 
            // btnCalculateCenterOfEachCluster
            // 
            this.btnCalculateCenterOfEachCluster.Location = new System.Drawing.Point(1137, 407);
            this.btnCalculateCenterOfEachCluster.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateCenterOfEachCluster.Name = "btnCalculateCenterOfEachCluster";
            this.btnCalculateCenterOfEachCluster.Size = new System.Drawing.Size(244, 28);
            this.btnCalculateCenterOfEachCluster.TabIndex = 6;
            this.btnCalculateCenterOfEachCluster.Text = "Calculate center of each cluster";
            this.btnCalculateCenterOfEachCluster.UseVisualStyleBackColor = true;
            this.btnCalculateCenterOfEachCluster.Click += new System.EventHandler(this.btnCalculateCenterOfEachCluster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SihoutteRadio);
            this.groupBox1.Controls.Add(this.elbowRadio);
            this.groupBox1.Location = new System.Drawing.Point(1139, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(183, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cluster options";
            // 
            // SihoutteRadio
            // 
            this.SihoutteRadio.AutoSize = true;
            this.SihoutteRadio.Location = new System.Drawing.Point(19, 52);
            this.SihoutteRadio.Margin = new System.Windows.Forms.Padding(4);
            this.SihoutteRadio.Name = "SihoutteRadio";
            this.SihoutteRadio.Size = new System.Drawing.Size(79, 20);
            this.SihoutteRadio.TabIndex = 1;
            this.SihoutteRadio.Text = "Silhoutte";
            this.SihoutteRadio.UseVisualStyleBackColor = true;
            this.SihoutteRadio.CheckedChanged += new System.EventHandler(this.SihoutteRadio_CheckedChanged);
            this.SihoutteRadio.Click += new System.EventHandler(this.SihoutteRadio_Click);
            // 
            // elbowRadio
            // 
            this.elbowRadio.AutoSize = true;
            this.elbowRadio.Location = new System.Drawing.Point(19, 23);
            this.elbowRadio.Margin = new System.Windows.Forms.Padding(4);
            this.elbowRadio.Name = "elbowRadio";
            this.elbowRadio.Size = new System.Drawing.Size(65, 20);
            this.elbowRadio.TabIndex = 0;
            this.elbowRadio.Text = "Eibow";
            this.elbowRadio.UseVisualStyleBackColor = true;
            this.elbowRadio.CheckedChanged += new System.EventHandler(this.elbowRadio_CheckedChanged);
            this.elbowRadio.Click += new System.EventHandler(this.elbowRadio_Click);
            // 
            // tfNumberOfCluster
            // 
            this.tfNumberOfCluster.Location = new System.Drawing.Point(1268, 68);
            this.tfNumberOfCluster.Margin = new System.Windows.Forms.Padding(4);
            this.tfNumberOfCluster.Name = "tfNumberOfCluster";
            this.tfNumberOfCluster.Size = new System.Drawing.Size(87, 22);
            this.tfNumberOfCluster.TabIndex = 8;
            this.tfNumberOfCluster.Text = "4";
            this.tfNumberOfCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1135, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cluster Number :";
            // 
            // btnFindTheResult
            // 
            this.btnFindTheResult.Location = new System.Drawing.Point(1139, 464);
            this.btnFindTheResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindTheResult.Name = "btnFindTheResult";
            this.btnFindTheResult.Size = new System.Drawing.Size(244, 28);
            this.btnFindTheResult.TabIndex = 10;
            this.btnFindTheResult.Text = "Find the result";
            this.btnFindTheResult.UseVisualStyleBackColor = true;
            this.btnFindTheResult.Click += new System.EventHandler(this.btnFindTheResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1133, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Year";
            // 
            // YearCb
            // 
            this.YearCb.FormattingEnabled = true;
            this.YearCb.Location = new System.Drawing.Point(1268, 33);
            this.YearCb.Name = "YearCb";
            this.YearCb.Size = new System.Drawing.Size(87, 24);
            this.YearCb.TabIndex = 14;
            this.YearCb.DropDown += new System.EventHandler(this.YearCb_DropDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(1306, 764);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // KmeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 801);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.YearCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindTheResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfNumberOfCluster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculateCenterOfEachCluster);
            this.Controls.Add(this.btnAssignDataPointsToCloserCluster);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInitializeCluster);
            this.Controls.Add(this.btnReset);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KmeanForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KmeanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInitializeCluster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssignDataPointsToCloserCluster;
        private System.Windows.Forms.Button btnCalculateCenterOfEachCluster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SihoutteRadio;
        private System.Windows.Forms.RadioButton elbowRadio;
        private System.Windows.Forms.TextBox tfNumberOfCluster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindTheResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox YearCb;
        private System.Windows.Forms.Button okBtn;
    }
}

