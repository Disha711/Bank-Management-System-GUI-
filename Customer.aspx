<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="BankManagent.Customer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Customer Menu</title>
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

        .go-back-btn {
            background: #f44336;
        }

        .go-back-btn:hover {
            background: #e53935;
        }

        .balance {
            font-size: 18px;
            margin-bottom: 15px;
            color: #333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Customer Login</h2>
            <asp:TextBox ID="AccountNumberTextBox" runat="server" placeholder="Enter Account Number" CssClass="form-input" /><br />
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" placeholder="Enter Password" CssClass="form-input" /><br />
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="form-button" OnClick="Login_Click" /><br /><br />

            <asp:Label ID="BalanceLabel" runat="server" Text="Balance: " CssClass="balance" /><br />

            <asp:TextBox ID="AmountTextBox" runat="server" placeholder="Enter Amount" CssClass="form-input" /><br />

            <asp:Button ID="Button2" runat="server" Text="Withdraw" CssClass="form-button" OnClick="Withdraw_Click" /><br />
            <asp:Button ID="Button3" runat="server" Text="Deposit" CssClass="form-button" OnClick="Deposit_Click" /><br />

            <!-- Go back button -->
            <asp:Button ID="GoBackButton" runat="server" Text="Go Back" CssClass="form-button go-back-btn" OnClick="GoBack_Click" />
        </div>
    </form>
</body>
</html>
