using System;
using System.Collections.Generic;
using System.Web.UI;

namespace BankManagent
{
    public partial class Banker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private List<CustomerAccount> GetCustomerAccountsFromSession()
        {
            if (Session["CustomerAccounts"] == null)
            {
                Session["CustomerAccounts"] = new List<CustomerAccount>();
            }

            return (List<CustomerAccount>)Session["CustomerAccounts"];
        }

        protected void CreateCustomerAccount_Click(object sender, EventArgs e)
        {
            int accountNumber;
            double balance;

            if (!int.TryParse(AccountNumberTextBox.Text, out accountNumber))
            {
                Response.Write("Account Number must be a valid integer.<br>");
                return;
            }

            if (!double.TryParse(BalanceTextBox.Text, out balance))
            {
                Response.Write("Balance must be a valid number.<br>");
                return;
            }

            string name = NameTextBox.Text;
            string accountType = AccountTypeDropDownList.SelectedValue; // Ensure the name matches the .aspx ID
            string password = PasswordTextBox.Text;

            CustomerAccount customer = new CustomerAccount
            {
                Name = name,
                AccountNumber = accountNumber,
                Password = password,
                AccountType = accountType,
                Balance = balance
            };

            var customerAccounts = GetCustomerAccountsFromSession();
            customerAccounts.Add(customer);

            Session["CustomerAccounts"] = customerAccounts;

            Response.Write("Customer account created successfully.");
        }

        protected void DisplayAllCustomerAccounts_Click(object sender, EventArgs e)
        {
            var customerAccounts = GetCustomerAccountsFromSession();

            if (customerAccounts.Count == 0)
            {
                Response.Write("No customer accounts found.<br>");
                return;
            }

            foreach (var customer in customerAccounts)
            {
                Response.Write(
                    "Name: " + customer.Name +
                    ", Account Number: " + customer.AccountNumber +
                    ", Account Type: " + customer.AccountType +
                    ", Balance: " + customer.Balance +
                    "<br>"
                );
            }
        }

        protected void GoToBackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        public class CustomerAccount
        {
            public string Name { get; set; }
            public int AccountNumber { get; set; }
            public string Password { get; set; }
            public string AccountType { get; set; }
            public double Balance { get; set; }
        }
    }
}
