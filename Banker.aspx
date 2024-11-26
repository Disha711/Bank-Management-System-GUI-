<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Banker.aspx.cs" Inherits="BankManagent.Banker" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Banker Page</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: #f4f7fc;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .container {
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            padding: 40px;
            text-align: center;
            width: 350px;
        }

        h2 {
            color: #333;
            font-size: 24px;
            margin-bottom: 20px;
        }

        .form-input, .form-button {
            width: 100%;
            padding: 12px;
            margin: 10px 0;
            border-radius: 5px;
            font-size: 16px;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        .form-input:focus {
            border-color: #4CAF50;
            outline: none;
        }

        .form-button {
            background: #4CAF50;
            color: white;
            cursor: pointer;
            border: none;
            transition: background 0.3s ease;
        }

        .form-button:hover {
            background: #45a049;
        }

        .back-btn {
            background: #f44336;
        }

        .back-btn:hover {
            background: #e53935;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Banker Menu</h2>
            <h3>Create Customer Account</h3>
            <asp:TextBox ID="NameTextBox" runat="server" Placeholder="Name" CssClass="form-input" /><br />
            <asp:TextBox ID="AccountNumberTextBox" runat="server" Placeholder="Account Number" CssClass="form-input" /><br />
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Placeholder="Password" CssClass="form-input" /><br />
            <asp:TextBox ID="BalanceTextBox" runat="server" Placeholder="Balance" CssClass="form-input" /><br />
            <asp:DropDownList ID="AccountTypeDropDownList" runat="server" CssClass="form-input">
                <asp:ListItem Value="Saving">Saving</asp:ListItem>
                <asp:ListItem Value="Current">Current</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Button ID="CreateCustomerAccountButton" runat="server" Text="Create Account" CssClass="form-button" OnClick="CreateCustomerAccount_Click" /><br />
            <asp:Button ID="DisplayAccountsButton" runat="server" Text="Display Accounts" CssClass="form-button" OnClick="DisplayAllCustomerAccounts_Click" /><br />
            <asp:Button ID="GoToBackButton" runat="server" Text="Go to Back" CssClass="form-button back-btn" OnClick="GoToBackButton_Click" />
        </div>
    </form>
</body>
</html>
