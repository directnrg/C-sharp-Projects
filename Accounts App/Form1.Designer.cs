
namespace AccountsApp
{
    partial class Accounts
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
            this.gpAccountDetails = new System.Windows.Forms.GroupBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDayWithdrawLimit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblDayWithdrawLimit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.gpTypeOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.rbtChecking = new System.Windows.Forms.RadioButton();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gpAccountDetails.SuspendLayout();
            this.gpTypeOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpAccountDetails
            // 
            this.gpAccountDetails.Controls.Add(this.txtInterestRate);
            this.gpAccountDetails.Controls.Add(this.txtDayWithdrawLimit);
            this.gpAccountDetails.Controls.Add(this.txtBalance);
            this.gpAccountDetails.Controls.Add(this.txtClientName);
            this.gpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.gpAccountDetails.Controls.Add(this.lblInterestRate);
            this.gpAccountDetails.Controls.Add(this.lblDayWithdrawLimit);
            this.gpAccountDetails.Controls.Add(this.lblBalance);
            this.gpAccountDetails.Controls.Add(this.lblClientName);
            this.gpAccountDetails.Controls.Add(this.lblAccountNumber);
            this.gpAccountDetails.Controls.Add(this.gpTypeOfAccount);
            this.gpAccountDetails.Location = new System.Drawing.Point(29, 56);
            this.gpAccountDetails.Name = "gpAccountDetails";
            this.gpAccountDetails.Size = new System.Drawing.Size(736, 285);
            this.gpAccountDetails.TabIndex = 0;
            this.gpAccountDetails.TabStop = false;
            this.gpAccountDetails.Text = "Account Details:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(223, 235);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRate.TabIndex = 10;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.txtInterestRate_TextChanged);
            // 
            // txtDayWithdrawLimit
            // 
            this.txtDayWithdrawLimit.Location = new System.Drawing.Point(223, 182);
            this.txtDayWithdrawLimit.Name = "txtDayWithdrawLimit";
            this.txtDayWithdrawLimit.Size = new System.Drawing.Size(100, 22);
            this.txtDayWithdrawLimit.TabIndex = 9;
            this.txtDayWithdrawLimit.TextChanged += new System.EventHandler(this.txtDayWithdrawLimit_TextChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(223, 139);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 8;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(223, 98);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(235, 22);
            this.txtClientName.TabIndex = 7;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(223, 52);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 22);
            this.txtAccountNumber.TabIndex = 6;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(32, 235);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(89, 17);
            this.lblInterestRate.TabIndex = 5;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // lblDayWithdrawLimit
            // 
            this.lblDayWithdrawLimit.AutoSize = true;
            this.lblDayWithdrawLimit.Location = new System.Drawing.Point(32, 188);
            this.lblDayWithdrawLimit.Name = "lblDayWithdrawLimit";
            this.lblDayWithdrawLimit.Size = new System.Drawing.Size(134, 17);
            this.lblDayWithdrawLimit.TabIndex = 4;
            this.lblDayWithdrawLimit.Text = "Daily Withdraw Limit";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(32, 145);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 17);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(32, 98);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(88, 17);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(32, 52);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(113, 17);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // gpTypeOfAccount
            // 
            this.gpTypeOfAccount.Controls.Add(this.rbtnVisa);
            this.gpTypeOfAccount.Controls.Add(this.rbtChecking);
            this.gpTypeOfAccount.Location = new System.Drawing.Point(505, 30);
            this.gpTypeOfAccount.Name = "gpTypeOfAccount";
            this.gpTypeOfAccount.Size = new System.Drawing.Size(201, 147);
            this.gpTypeOfAccount.TabIndex = 0;
            this.gpTypeOfAccount.TabStop = false;
            this.gpTypeOfAccount.Text = "Type of Account";
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Location = new System.Drawing.Point(34, 88);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(56, 21);
            this.rbtnVisa.TabIndex = 1;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            this.rbtnVisa.CheckedChanged += new System.EventHandler(this.rbtnVisa_CheckedChanged);
            // 
            // rbtChecking
            // 
            this.rbtChecking.AutoSize = true;
            this.rbtChecking.Location = new System.Drawing.Point(34, 45);
            this.rbtChecking.Name = "rbtChecking";
            this.rbtChecking.Size = new System.Drawing.Size(87, 21);
            this.rbtChecking.TabIndex = 0;
            this.rbtChecking.TabStop = true;
            this.rbtChecking.Text = "Checking";
            this.rbtChecking.UseVisualStyleBackColor = true;
            this.rbtChecking.CheckedChanged += new System.EventHandler(this.rbtChecking_CheckedChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(632, 359);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(133, 45);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(691, 19);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(73, 36);
            this.btnSearchAccount.TabIndex = 22;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearch_click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Location = new System.Drawing.Point(488, 26);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(177, 22);
            this.txtSearchAccount.TabIndex = 21;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(285, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(186, 17);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search By Account Number:";
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.gpAccountDetails);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.gpAccountDetails.ResumeLayout(false);
            this.gpAccountDetails.PerformLayout();
            this.gpTypeOfAccount.ResumeLayout(false);
            this.gpTypeOfAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAccountDetails;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDayWithdrawLimit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblDayWithdrawLimit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.GroupBox gpTypeOfAccount;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.RadioButton rbtChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Label lblSearch;
    }
}

