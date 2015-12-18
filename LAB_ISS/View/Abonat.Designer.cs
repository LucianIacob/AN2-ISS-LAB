namespace LAB_ISS
{
    partial class Abonat
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
            this.lstPublicationsInAbonatPanel = new System.Windows.Forms.ListBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPublicationsInAbonatPanel
            // 
            this.lstPublicationsInAbonatPanel.FormattingEnabled = true;
            this.lstPublicationsInAbonatPanel.Location = new System.Drawing.Point(6, 25);
            this.lstPublicationsInAbonatPanel.Name = "lstPublicationsInAbonatPanel";
            this.lstPublicationsInAbonatPanel.Size = new System.Drawing.Size(321, 264);
            this.lstPublicationsInAbonatPanel.TabIndex = 2;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(6, 295);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(321, 28);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lstPublicationsInAbonatPanel);
            this.groupBox1.Controls.Add(this.btnBorrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Library publications";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(6, 326);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // Abonat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 360);
            this.Controls.Add(this.groupBox1);
            this.Name = "Abonat";
            this.Text = "Abonat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPublicationsInAbonatPanel;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
    }
}