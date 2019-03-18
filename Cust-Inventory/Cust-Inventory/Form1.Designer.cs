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
        private void InitializeComponent()
        {
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.customersControl1 = new Cust_Inventory.CustomersControl();
            this.homeControl1 = new Cust_Inventory.HomeControl();
            this.reportsControl1 = new Cust_Inventory.ReportsControl();
            this.usersControl1 = new Cust_Inventory.UsersControl();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 61);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(0, 103);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(142, 38);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(0, 147);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(142, 39);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(0, 192);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(142, 42);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // customersControl1
            // 
            this.customersControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customersControl1.Location = new System.Drawing.Point(148, 0);
            this.customersControl1.Name = "customersControl1";
            this.customersControl1.Size = new System.Drawing.Size(1229, 582);
            this.customersControl1.TabIndex = 4;
            // 
            // homeControl1
            // 
            this.homeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.homeControl1.Location = new System.Drawing.Point(148, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1229, 582);
            this.homeControl1.TabIndex = 5;
            // 
            // reportsControl1
            // 
            this.reportsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reportsControl1.Location = new System.Drawing.Point(148, 0);
            this.reportsControl1.Name = "reportsControl1";
            this.reportsControl1.Size = new System.Drawing.Size(1229, 582);
            this.reportsControl1.TabIndex = 6;
            // 
            // usersControl1
            // 
            this.usersControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.usersControl1.Location = new System.Drawing.Point(148, 0);
            this.usersControl1.Name = "usersControl1";
            this.usersControl1.Size = new System.Drawing.Size(1229, 582);
            this.usersControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1376, 793);
            this.Controls.Add(this.usersControl1);
            this.Controls.Add(this.reportsControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.customersControl1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnHome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yakesh Steel Inventory Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnReports;
        private CustomersControl customersControl1;
        private HomeControl homeControl1;
        private ReportsControl reportsControl1;
        private UsersControl usersControl1;
    }
}

