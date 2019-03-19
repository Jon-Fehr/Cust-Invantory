namespace Cust_Inventory
{
    partial class CustomersControl
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.rBNameSearch = new System.Windows.Forms.RadioButton();
            this.rBBusinessSearch = new System.Windows.Forms.RadioButton();
            this.rBNumberSearch = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBShowAll = new System.Windows.Forms.RadioButton();
            this.tBPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tBBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.tBLName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tBFName = new System.Windows.Forms.TextBox();
            this.dGVCustLookUp = new System.Windows.Forms.DataGridView();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCustLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(8, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(227, 34);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Search";
            // 
            // rBNameSearch
            // 
            this.rBNameSearch.AutoSize = true;
            this.rBNameSearch.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNameSearch.Location = new System.Drawing.Point(14, 76);
            this.rBNameSearch.Name = "rBNameSearch";
            this.rBNameSearch.Size = new System.Drawing.Size(140, 24);
            this.rBNameSearch.TabIndex = 1;
            this.rBNameSearch.TabStop = true;
            this.rBNameSearch.Text = "Search By Name";
            this.rBNameSearch.UseVisualStyleBackColor = true;
            this.rBNameSearch.CheckedChanged += new System.EventHandler(this.rBNameSearch_CheckedChanged);
            // 
            // rBBusinessSearch
            // 
            this.rBBusinessSearch.AutoSize = true;
            this.rBBusinessSearch.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBBusinessSearch.Location = new System.Drawing.Point(14, 136);
            this.rBBusinessSearch.Name = "rBBusinessSearch";
            this.rBBusinessSearch.Size = new System.Drawing.Size(155, 24);
            this.rBBusinessSearch.TabIndex = 2;
            this.rBBusinessSearch.TabStop = true;
            this.rBBusinessSearch.Text = "Search By Business";
            this.rBBusinessSearch.UseVisualStyleBackColor = true;
            this.rBBusinessSearch.CheckedChanged += new System.EventHandler(this.rBBusinessSearch_CheckedChanged);
            // 
            // rBNumberSearch
            // 
            this.rBNumberSearch.AutoSize = true;
            this.rBNumberSearch.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNumberSearch.Location = new System.Drawing.Point(14, 106);
            this.rBNumberSearch.Name = "rBNumberSearch";
            this.rBNumberSearch.Size = new System.Drawing.Size(203, 24);
            this.rBNumberSearch.TabIndex = 3;
            this.rBNumberSearch.TabStop = true;
            this.rBNumberSearch.Text = "Search By Phone Number";
            this.rBNumberSearch.UseVisualStyleBackColor = true;
            this.rBNumberSearch.CheckedChanged += new System.EventHandler(this.rBNumberSearch_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindCustomer);
            this.panel1.Controls.Add(this.rBShowAll);
            this.panel1.Controls.Add(this.tBPhoneNumber);
            this.panel1.Controls.Add(this.rBNameSearch);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.rBNumberSearch);
            this.panel1.Controls.Add(this.tBBusinessName);
            this.panel1.Controls.Add(this.rBBusinessSearch);
            this.panel1.Controls.Add(this.lblBusinessName);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.tBLName);
            this.panel1.Controls.Add(this.lblContactName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.tBFName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 582);
            this.panel1.TabIndex = 4;
            // 
            // rBShowAll
            // 
            this.rBShowAll.AutoSize = true;
            this.rBShowAll.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBShowAll.Location = new System.Drawing.Point(14, 46);
            this.rBShowAll.Name = "rBShowAll";
            this.rBShowAll.Size = new System.Drawing.Size(166, 24);
            this.rBShowAll.TabIndex = 4;
            this.rBShowAll.TabStop = true;
            this.rBShowAll.Text = "Show All Customers";
            this.rBShowAll.UseVisualStyleBackColor = true;
            this.rBShowAll.CheckedChanged += new System.EventHandler(this.rBShowAll_CheckedChanged);
            // 
            // tBPhoneNumber
            // 
            this.tBPhoneNumber.Location = new System.Drawing.Point(14, 277);
            this.tBPhoneNumber.Name = "tBPhoneNumber";
            this.tBPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tBPhoneNumber.TabIndex = 12;
            this.tBPhoneNumber.Visible = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(11, 257);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 17);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Visible = false;
            // 
            // tBBusinessName
            // 
            this.tBBusinessName.Location = new System.Drawing.Point(14, 317);
            this.tBBusinessName.Name = "tBBusinessName";
            this.tBBusinessName.Size = new System.Drawing.Size(100, 20);
            this.tBBusinessName.TabIndex = 10;
            this.tBBusinessName.Visible = false;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.Location = new System.Drawing.Point(11, 297);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(93, 17);
            this.lblBusinessName.TabIndex = 9;
            this.lblBusinessName.Text = "Business Name";
            this.lblBusinessName.Visible = false;
            // 
            // tBLName
            // 
            this.tBLName.Location = new System.Drawing.Point(131, 220);
            this.tBLName.Name = "tBLName";
            this.tBLName.Size = new System.Drawing.Size(100, 20);
            this.tBLName.TabIndex = 8;
            this.tBLName.Visible = false;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(11, 174);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(95, 17);
            this.lblContactName.TabIndex = 4;
            this.lblContactName.Text = "Contact Name";
            this.lblContactName.Visible = false;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(128, 201);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(64, 16);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name";
            this.lblLName.Visible = false;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(11, 201);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(66, 16);
            this.lblFName.TabIndex = 6;
            this.lblFName.Text = "First Name";
            this.lblFName.Visible = false;
            // 
            // tBFName
            // 
            this.tBFName.Location = new System.Drawing.Point(14, 220);
            this.tBFName.Name = "tBFName";
            this.tBFName.Size = new System.Drawing.Size(100, 20);
            this.tBFName.TabIndex = 5;
            this.tBFName.Visible = false;
            // 
            // dGVCustLookUp
            // 
            this.dGVCustLookUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCustLookUp.Location = new System.Drawing.Point(244, 46);
            this.dGVCustLookUp.Name = "dGVCustLookUp";
            this.dGVCustLookUp.Size = new System.Drawing.Size(982, 533);
            this.dGVCustLookUp.TabIndex = 13;
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerList.Location = new System.Drawing.Point(607, 9);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(153, 28);
            this.lblCustomerList.TabIndex = 14;
            this.lblCustomerList.Text = "Customer List";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomer.Location = new System.Drawing.Point(0, 369);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(238, 23);
            this.btnFindCustomer.TabIndex = 13;
            this.btnFindCustomer.Text = "Find Customers";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.dGVCustLookUp);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(1229, 582);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCustLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.RadioButton rBNameSearch;
        private System.Windows.Forms.RadioButton rBBusinessSearch;
        private System.Windows.Forms.RadioButton rBNumberSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox tBFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox tBLName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox tBBusinessName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tBPhoneNumber;
        private System.Windows.Forms.RadioButton rBShowAll;
        private System.Windows.Forms.DataGridView dGVCustLookUp;
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.Button btnFindCustomer;
    }
}
