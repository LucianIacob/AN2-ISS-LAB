namespace LAB_ISS
{
    partial class Admin
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
            this.lstPublicationsInAdminPanel = new System.Windows.Forms.ListBox();
            this.lstBorrowedBooks = new System.Windows.Forms.ListBox();
            this.btnReturnPublication = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPublication = new System.Windows.Forms.Button();
            this.txtPublicationCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeletePublication = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblShowStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPublicationsInAdminPanel
            // 
            this.lstPublicationsInAdminPanel.FormattingEnabled = true;
            this.lstPublicationsInAdminPanel.Location = new System.Drawing.Point(6, 16);
            this.lstPublicationsInAdminPanel.Name = "lstPublicationsInAdminPanel";
            this.lstPublicationsInAdminPanel.Size = new System.Drawing.Size(268, 303);
            this.lstPublicationsInAdminPanel.TabIndex = 1;
            // 
            // lstBorrowedBooks
            // 
            this.lstBorrowedBooks.FormattingEnabled = true;
            this.lstBorrowedBooks.Location = new System.Drawing.Point(6, 16);
            this.lstBorrowedBooks.Name = "lstBorrowedBooks";
            this.lstBorrowedBooks.Size = new System.Drawing.Size(306, 303);
            this.lstBorrowedBooks.TabIndex = 4;
            // 
            // btnReturnPublication
            // 
            this.btnReturnPublication.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReturnPublication.Location = new System.Drawing.Point(6, 325);
            this.btnReturnPublication.Name = "btnReturnPublication";
            this.btnReturnPublication.Size = new System.Drawing.Size(306, 23);
            this.btnReturnPublication.TabIndex = 6;
            this.btnReturnPublication.Text = "Return selected";
            this.btnReturnPublication.UseVisualStyleBackColor = false;
            this.btnReturnPublication.Click += new System.EventHandler(this.btnReturnPublication_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnAddPublication);
            this.groupBox1.Controls.Add(this.txtPublicationCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(23, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD PUBLICATION";
            // 
            // btnAddPublication
            // 
            this.btnAddPublication.BackColor = System.Drawing.Color.Beige;
            this.btnAddPublication.Location = new System.Drawing.Point(9, 136);
            this.btnAddPublication.Name = "btnAddPublication";
            this.btnAddPublication.Size = new System.Drawing.Size(148, 23);
            this.btnAddPublication.TabIndex = 6;
            this.btnAddPublication.Text = "Add";
            this.btnAddPublication.UseVisualStyleBackColor = false;
            this.btnAddPublication.Click += new System.EventHandler(this.btnAddPublication_Click);
            // 
            // txtPublicationCode
            // 
            this.txtPublicationCode.Location = new System.Drawing.Point(9, 110);
            this.txtPublicationCode.Name = "txtPublicationCode";
            this.txtPublicationCode.Size = new System.Drawing.Size(148, 20);
            this.txtPublicationCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Publication code:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(9, 71);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(148, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(148, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtNewAuthor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNewTitle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(23, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EDIT PUBLICATION";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Location = new System.Drawing.Point(9, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewAuthor
            // 
            this.txtNewAuthor.Location = new System.Drawing.Point(9, 71);
            this.txtNewAuthor.Name = "txtNewAuthor";
            this.txtNewAuthor.Size = new System.Drawing.Size(148, 20);
            this.txtNewAuthor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "New author:";
            // 
            // txtNewTitle
            // 
            this.txtNewTitle.Location = new System.Drawing.Point(9, 32);
            this.txtNewTitle.Name = "txtNewTitle";
            this.txtNewTitle.Size = new System.Drawing.Size(148, 20);
            this.txtNewTitle.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "New title:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox4.Controls.Add(this.btnDeletePublication);
            this.groupBox4.Location = new System.Drawing.Point(23, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 49);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DELETE PUBLICATION";
            // 
            // btnDeletePublication
            // 
            this.btnDeletePublication.BackColor = System.Drawing.Color.Beige;
            this.btnDeletePublication.Location = new System.Drawing.Point(6, 19);
            this.btnDeletePublication.Name = "btnDeletePublication";
            this.btnDeletePublication.Size = new System.Drawing.Size(151, 23);
            this.btnDeletePublication.TabIndex = 0;
            this.btnDeletePublication.Text = "Delete selected";
            this.btnDeletePublication.UseVisualStyleBackColor = false;
            this.btnDeletePublication.Click += new System.EventHandler(this.btnDeletePublication_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnReturnPublication);
            this.groupBox6.Controls.Add(this.lstBorrowedBooks);
            this.groupBox6.Location = new System.Drawing.Point(480, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(318, 354);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Borrowed publications    (title;author;code;customer)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblShowStatus);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.lstPublicationsInAdminPanel);
            this.groupBox3.Location = new System.Drawing.Point(194, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 354);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Library publications    (title;author;code)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Location = new System.Drawing.Point(6, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // lblShowStatus
            // 
            this.lblShowStatus.AutoSize = true;
            this.lblShowStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShowStatus.Location = new System.Drawing.Point(46, 329);
            this.lblShowStatus.Name = "lblShowStatus";
            this.lblShowStatus.Size = new System.Drawing.Size(0, 13);
            this.lblShowStatus.TabIndex = 16;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 393);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPublicationsInAdminPanel;
        private System.Windows.Forms.ListBox lstBorrowedBooks;
        private System.Windows.Forms.Button btnReturnPublication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPublicationCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddPublication;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNewTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeletePublication;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblShowStatus;
    }
}