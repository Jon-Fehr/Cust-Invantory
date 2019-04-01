namespace Cust_Inventory
{
    partial class HomeControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelHomeInfo = new System.Windows.Forms.Panel();
            this.lblHLName = new System.Windows.Forms.Label();
            this.lblHFname = new System.Windows.Forms.Label();
            this.panelHomeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // panelHomeInfo
            // 
            this.panelHomeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHomeInfo.Controls.Add(this.lblHLName);
            this.panelHomeInfo.Controls.Add(this.label1);
            this.panelHomeInfo.Controls.Add(this.lblHFname);
            this.panelHomeInfo.Location = new System.Drawing.Point(3, 0);
            this.panelHomeInfo.Name = "panelHomeInfo";
            this.panelHomeInfo.Size = new System.Drawing.Size(1226, 792);
            this.panelHomeInfo.TabIndex = 6;
            // 
            // lblHLName
            // 
            this.lblHLName.AutoSize = true;
            this.lblHLName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHLName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHLName.Location = new System.Drawing.Point(194, 95);
            this.lblHLName.Name = "lblHLName";
            this.lblHLName.Size = new System.Drawing.Size(63, 21);
            this.lblHLName.TabIndex = 1;
            this.lblHLName.Text = "LName";
            // 
            // lblHFname
            // 
            this.lblHFname.AutoSize = true;
            this.lblHFname.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHFname.Location = new System.Drawing.Point(14, 95);
            this.lblHFname.Name = "lblHFname";
            this.lblHFname.Size = new System.Drawing.Size(62, 21);
            this.lblHFname.TabIndex = 0;
            this.lblHFname.Text = "FName";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelHomeInfo);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1229, 792);
            this.panelHomeInfo.ResumeLayout(false);
            this.panelHomeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHomeInfo;
        private System.Windows.Forms.Label lblHLName;
        private System.Windows.Forms.Label lblHFname;
    }
}
