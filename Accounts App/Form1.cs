using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class Accounts : Form
    {
        private List<Account> accounts  = new List<Account>();
        private Account myAccount;
        public Accounts()
        {
            InitializeComponent();
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDayWithdrawLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtChecking.Checked)
            {
                txtDayWithdrawLimit.Enabled = true;
                txtInterestRate.Enabled = false;
            }
            else
            {
                txtDayWithdrawLimit.Enabled = false;
                txtInterestRate.Enabled = true;
            }
        }

        private void rbtnVisa_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            accounts.Add(new CheckingAccount(654654, "Fabian Soto", 25000, 2000));

            accounts.Add(new VisaAccount(329432, "Aderson Olivera", 23000, 10));
        }
        private void ClearFields()
        {
            txtAccountNumber.Text = "";
            txtBalance.Text = "";
            txtClientName.Text = "";

            txtDayWithdrawLimit.Text = "";
            txtInterestRate.Text = "";

            rbtChecking.Checked = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtChecking.Checked)
                {
                    accounts.Add(new CheckingAccount(int.Parse(txtAccountNumber.Text), txtClientName.Text,
                        double.Parse(txtBalance.Text), double.Parse(txtDayWithdrawLimit.Text)));
                }

                if (rbtnVisa.Checked)
                {
                    accounts.Add(new VisaAccount(int.Parse(txtAccountNumber.Text), txtClientName.Text,
                        double.Parse(txtBalance.Text), double.Parse(txtInterestRate.Text)));
                }

                rbtChecking.Checked = true;

                ClearFields();

                // To count the accounts created
                MessageBox.Show($"Total number of Accounts is: {accounts.Count}");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearch_click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
                myAccount = null;

                foreach (Account account in accounts)
                {
                    if (account.Number == int.Parse(txtSearchAccount.Text))
                        myAccount = account;
                }

                txtClientName.Text = myAccount.ClientName;
                txtAccountNumber.Text = myAccount.Number.ToString();
                txtBalance.Text = myAccount.Balance.ToString();
                
                if (myAccount is CheckingAccount)
                {
                    txtDayWithdrawLimit.Text = (myAccount as CheckingAccount).WithdrawLimit.ToString();
                    
                    rbtChecking.Checked = true;
                    rbtnVisa.Checked = false;
                }
                else
                if (myAccount is VisaAccount)
                {
                    txtInterestRate.Text = (myAccount as VisaAccount).InterestRate.ToString();

                    rbtChecking.Checked = false;
                    rbtnVisa.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                ClearFields();

                MessageBox.Show("Account not found!");
            }
        }
    }
}
