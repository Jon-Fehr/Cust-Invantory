namespace Cust_Inventory
{
    partial class Form1
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
        public void InitializeComponent()
        {
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlHomeButtonControl = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMainControls = new System.Windows.Forms.Panel();
            this.pnlHomeButtonControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(4, 68);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(145, 39);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(4, 185);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(145, 38);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(7, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(4, 125);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(145, 42);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlHomeButtonControl
            // 
            this.pnlHomeButtonControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHomeButtonControl.Controls.Add(this.btnReports);
            this.pnlHomeButtonControl.Controls.Add(this.btnHome);
            this.pnlHomeButtonControl.Controls.Add(this.btnUsers);
            this.pnlHomeButtonControl.Controls.Add(this.btnCustomer);
            this.pnlHomeButtonControl.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeButtonControl.Name = "pnlHomeButtonControl";
            this.pnlHomeButtonControl.Size = new System.Drawing.Size(163, 793);
            this.pnlHomeButtonControl.TabIndex = 8;
            // 
            // pnlMainControls
            // 
            this.pnlMainControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMainControls.Location = new System.Drawing.Point(169, 12);
            this.pnlMainControls.Name = "pnlMainControls";
            this.pnlMainControls.Size = new System.Drawing.Size(1236, 626);
            this.pnlMainControls.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1405, 793);
            this.Controls.Add(this.pnlMainControls);
            this.Controls.Add(this.pnlHomeButtonControl);
            this.MinimumSize = new System.Drawing.Size(1421, 832);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yakesh Steel Inventory Program";
            this.pnlHomeButtonControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCustomer;
        public System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlHomeButtonControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlMainControls;
    }
}

