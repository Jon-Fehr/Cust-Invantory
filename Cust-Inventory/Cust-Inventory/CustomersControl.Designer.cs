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
            this.lblAddCustEmail = new System.Windows.Forms.Label();
            this.lblAddCustZip = new System.Windows.Forms.Label();
            this.lblAddCustState = new System.Windows.Forms.Label();
            this.tbAddCustZip = new System.Windows.Forms.TextBox();
            this.tbAddCustState = new System.Windows.Forms.TextBox();
            this.tbAddCustAddress = new System.Windows.Forms.TextBox();
            this.lblAddCustBussAddress = new System.Windows.Forms.Label();
            this.tbAddCustBussName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddCustPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddCustPhoneNum = new System.Windows.Forms.Label();
            this.tbAddCustLName = new System.Windows.Forms.TextBox();
            this.tbAddCustFName = new System.Windows.Forms.TextBox();
            this.lblAddCustLName = new System.Windows.Forms.Label();
            this.lblAddCustFname = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
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
            this.tbAddCustBusEmail = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.tbAddCustBusEmail);
            this.panel1.Controls.Add(this.lblAddCustEmail);
            this.panel1.Controls.Add(this.lblAddCustZip);
            this.panel1.Controls.Add(this.lblAddCustState);
            this.panel1.Controls.Add(this.tbAddCustZip);
            this.panel1.Controls.Add(this.tbAddCustState);
            this.panel1.Controls.Add(this.tbAddCustAddress);
            this.panel1.Controls.Add(this.lblAddCustBussAddress);
            this.panel1.Controls.Add(this.tbAddCustBussName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbAddCustPhoneNumber);
            this.panel1.Controls.Add(this.lblAddCustPhoneNum);
            this.panel1.Controls.Add(this.tbAddCustLName);
            this.panel1.Controls.Add(this.tbAddCustFName);
            this.panel1.Controls.Add(this.lblAddCustLName);
            this.panel1.Controls.Add(this.lblAddCustFname);
            this.panel1.Controls.Add(this.lblContactInfo);
            this.panel1.Controls.Add(this.lblAddCustomer);
            this.panel1.Controls.Add(this.button1);
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
            this.panel1.Size = new System.Drawing.Size(238, 792);
            this.panel1.TabIndex = 4;
            // 
            // lblAddCustEmail
            // 
            this.lblAddCustEmail.AutoSize = true;
            this.lblAddCustEmail.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustEmail.Location = new System.Drawing.Point(7, 687);
            this.lblAddCustEmail.Name = "lblAddCustEmail";
            this.lblAddCustEmail.Size = new System.Drawing.Size(91, 17);
            this.lblAddCustEmail.TabIndex = 31;
            this.lblAddCustEmail.Text = "Business Email";
            this.lblAddCustEmail.Visible = false;
            // 
            // lblAddCustZip
            // 
            this.lblAddCustZip.AutoSize = true;
            this.lblAddCustZip.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustZip.Location = new System.Drawing.Point(129, 632);
            this.lblAddCustZip.Name = "lblAddCustZip";
            this.lblAddCustZip.Size = new System.Drawing.Size(63, 17);
            this.lblAddCustZip.TabIndex = 30;
            this.lblAddCustZip.Text = "Zip Code";
            this.lblAddCustZip.Visible = false;
            // 
            // lblAddCustState
            // 
            this.lblAddCustState.AutoSize = true;
            this.lblAddCustState.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustState.Location = new System.Drawing.Point(7, 632);
            this.lblAddCustState.Name = "lblAddCustState";
            this.lblAddCustState.Size = new System.Drawing.Size(42, 17);
            this.lblAddCustState.TabIndex = 29;
            this.lblAddCustState.Text = "State";
            this.lblAddCustState.Visible = false;
            // 
            // tbAddCustZip
            // 
            this.tbAddCustZip.Location = new System.Drawing.Point(131, 652);
            this.tbAddCustZip.Name = "tbAddCustZip";
            this.tbAddCustZip.Size = new System.Drawing.Size(100, 20);
            this.tbAddCustZip.TabIndex = 28;
            this.tbAddCustZip.Visible = false;
            // 
            // tbAddCustState
            // 
            this.tbAddCustState.Location = new System.Drawing.Point(14, 652);
            this.tbAddCustState.Name = "tbAddCustState";
            this.tbAddCustState.Size = new System.Drawing.Size(100, 20);
            this.tbAddCustState.TabIndex = 27;
            this.tbAddCustState.Visible = false;
            // 
            // tbAddCustAddress
            // 
            this.tbAddCustAddress.Location = new System.Drawing.Point(14, 600);
            this.tbAddCustAddress.Name = "tbAddCustAddress";
            this.tbAddCustAddress.Size = new System.Drawing.Size(217, 20);
            this.tbAddCustAddress.TabIndex = 26;
            this.tbAddCustAddress.Visible = false;
            // 
            // lblAddCustBussAddress
            // 
            this.lblAddCustBussAddress.AutoSize = true;
            this.lblAddCustBussAddress.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustBussAddress.Location = new System.Drawing.Point(11, 580);
            this.lblAddCustBussAddress.Name = "lblAddCustBussAddress";
            this.lblAddCustBussAddress.Size = new System.Drawing.Size(105, 17);
            this.lblAddCustBussAddress.TabIndex = 25;
            this.lblAddCustBussAddress.Text = "Business Address";
            this.lblAddCustBussAddress.Visible = false;
            // 
            // tbAddCustBussName
            // 
            this.tbAddCustBussName.Location = new System.Drawing.Point(131, 542);
            this.tbAddCustBussName.Name = "tbAddCustBussName";
            this.tbAddCustBussName.Size = new System.Drawing.Size(100, 20);
            this.tbAddCustBussName.TabIndex = 24;
            this.tbAddCustBussName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Business Name";
            this.label1.Visible = false;
            // 
            // tbAddCustPhoneNumber
            // 
            this.tbAddCustPhoneNumber.Location = new System.Drawing.Point(14, 542);
            this.tbAddCustPhoneNumber.Name = "tbAddCustPhoneNumber";
            this.tbAddCustPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbAddCustPhoneNumber.TabIndex = 22;
            this.tbAddCustPhoneNumber.Visible = false;
            // 
            // lblAddCustPhoneNum
            // 
            this.lblAddCustPhoneNum.AutoSize = true;
            this.lblAddCustPhoneNum.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustPhoneNum.Location = new System.Drawing.Point(7, 522);
            this.lblAddCustPhoneNum.Name = "lblAddCustPhoneNum";
            this.lblAddCustPhoneNum.Size = new System.Drawing.Size(97, 17);
            this.lblAddCustPhoneNum.TabIndex = 21;
            this.lblAddCustPhoneNum.Text = "Phone Number";
            this.lblAddCustPhoneNum.Visible = false;
            // 
            // tbAddCustLName
            // 
            this.tbAddCustLName.Location = new System.Drawing.Point(131, 487);
            this.tbAddCustLName.Name = "tbAddCustLName";
            this.tbAddCustLName.Size = new System.Drawing.Size(100, 20);
            this.tbAddCustLName.TabIndex = 20;
            this.tbAddCustLName.Visible = false;
            // 
            // tbAddCustFName
            // 
            this.tbAddCustFName.Location = new System.Drawing.Point(14, 487);
            this.tbAddCustFName.Name = "tbAddCustFName";
            this.tbAddCustFName.Size = new System.Drawing.Size(100, 20);
            this.tbAddCustFName.TabIndex = 19;
            this.tbAddCustFName.Visible = false;
            // 
            // lblAddCustLName
            // 
            this.lblAddCustLName.AutoSize = true;
            this.lblAddCustLName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustLName.Location = new System.Drawing.Point(128, 468);
            this.lblAddCustLName.Name = "lblAddCustLName";
            this.lblAddCustLName.Size = new System.Drawing.Size(73, 17);
            this.lblAddCustLName.TabIndex = 18;
            this.lblAddCustLName.Text = "Last Name";
            this.lblAddCustLName.Visible = false;
            // 
            // lblAddCustFname
            // 
            this.lblAddCustFname.AutoSize = true;
            this.lblAddCustFname.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustFname.Location = new System.Drawing.Point(11, 468);
            this.lblAddCustFname.Name = "lblAddCustFname";
            this.lblAddCustFname.Size = new System.Drawing.Size(75, 17);
            this.lblAddCustFname.TabIndex = 17;
            this.lblAddCustFname.Text = "First Name";
            this.lblAddCustFname.Visible = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(61, 441);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(85, 17);
            this.lblContactInfo.TabIndex = 16;
            this.lblContactInfo.Text = "Contact Info";
            this.lblContactInfo.Visible = false;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(22, 407);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(195, 34);
            this.lblAddCustomer.TabIndex = 15;
            this.lblAddCustomer.Text = "Add Customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 752);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dGVCustLookUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCustLookUp_CellContentClick);
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
            // tbAddCustBusEmail
            // 
            this.tbAddCustBusEmail.Location = new System.Drawing.Point(14, 714);
            this.tbAddCustBusEmail.Name = "tbAddCustBusEmail";
            this.tbAddCustBusEmail.Size = new System.Drawing.Size(216, 20);
            this.tbAddCustBusEmail.TabIndex = 32;
            this.tbAddCustBusEmail.Visible = false;
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.dGVCustLookUp);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(1232, 792);
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
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddCustEmail;
        private System.Windows.Forms.Label lblAddCustZip;
        private System.Windows.Forms.Label lblAddCustState;
        private System.Windows.Forms.TextBox tbAddCustZip;
        private System.Windows.Forms.TextBox tbAddCustState;
        private System.Windows.Forms.TextBox tbAddCustAddress;
        private System.Windows.Forms.Label lblAddCustBussAddress;
        private System.Windows.Forms.TextBox tbAddCustBussName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddCustPhoneNumber;
        private System.Windows.Forms.Label lblAddCustPhoneNum;
        private System.Windows.Forms.TextBox tbAddCustLName;
        private System.Windows.Forms.TextBox tbAddCustFName;
        private System.Windows.Forms.Label lblAddCustLName;
        private System.Windows.Forms.Label lblAddCustFname;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.TextBox tbAddCustBusEmail;
    }
}
