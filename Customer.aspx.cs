using System;
using System.Collections.Generic;
using System.Web.UI;

namespace BankManagent
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private List<Banker.CustomerAccount> GetCustomerAccountsFromSession()
        {
            if (Session["CustomerAccounts"] == null)
            {
                return new List<Banker.CustomerAccount>();
            }

            return (List<Banker.CustomerAccount>)Session["CustomerAccounts"];
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            int accountNumber;
            if (!int.TryParse(AccountNumberTextBox.Text, out accountNumber))
            {
                Response.Write("Account Number must be a valid integer.<br>");
                return;
            }
            string password = PasswordTextBox.Text.Trim();

            var customerAccounts = GetCustomerAccountsFromSession();

            // Validate account number and password
            var customer = customerAccounts.Find(c => c.AccountNumber == accountNumber && c.Password == password);

            if (customer != null)
            {
                BalanceLabel.Text = "Welcome, " + customer.Name + ". Your balance is: " + customer.Balance;
            }
            else
            {
                Response.Write("Invalid account number or password.<br>");
            }
        }

        protected void Withdraw_Click(object sender, EventArgs e)
        {
            int accountNumber;
            double withdrawAmount;

            if (!int.TryParse(AccountNumberTextBox.Text, out accountNumber))
            {
                Response.Write("Account Number must be a valid integer.<br>");
                return;
            }

            if (!double.TryParse(AmountTextBox.Text, out withdrawAmount))
            {
                Response.Write("Please enter a valid withdrawal amount.<br>");
                return;
            }

            var customerAccounts = GetCustomerAccountsFromSession();
            var customer = customerAccounts.Find(c => c.AccountNumber == accountNumber);

            if (customer != null)
            {
                if (customer.Balance >= withdrawAmount)
                {
                    customer.Balance -= withdrawAmount;
                    BalanceLabel.Text = "Your new balance is: " + customer.Balance;
                    Session["CustomerAccounts"] = customerAccounts; // Update session
                }
                else
                {
                    Response.Write("Insufficient balance.<br>");
                }
            }
            else
            {
                Response.Write("Account not found.<br>");
            }
        }

        protected void Deposit_Click(object sender, EventArgs e)
        {
            int accountNumber;
            double depositAmount;

            if (!int.TryParse(AccountNumberTextBox.Text, out accountNumber))
            {
                Response.Write("Account Number must be a valid integer.<br>");
                return;
            }

            if (!double.TryParse(AmountTextBox.Text, out depositAmount))
            {
                Response.Write("Please enter a valid deposit amount.<br>");
                return;
            }

            var customerAccounts = GetCustomerAccountsFromSession();
            var customer = customerAccounts.Find(c => c.AccountNumber == accountNumber);

            if (customer != null)
            {
                customer.Balance += depositAmount;
                BalanceLabel.Text = "Your new balance is: " + customer.Balance;
                Session["CustomerAccounts"] = customerAccounts; // Update session
            }
            else
            {
                Response.Write("Account not found.<br>");
            }
        }
        protected void GoBack_Click(object sender, EventArgs e)
        {
            // Code to handle the "Go Back" action.
            // For example, redirect the user to a previous page or home page.
            Response.Redirect("Default.aspx"); // Replace "HomePage.aspx" with your actual home page or previous page
        }

    }
}
