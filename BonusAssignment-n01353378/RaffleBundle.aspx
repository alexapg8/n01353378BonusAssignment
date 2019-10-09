<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RaffleBundle.aspx.cs" Inherits="BonusAssignment_n01353378.RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
            <h1>Enter the number of tickets:</h1>
               <asp:TextBox runat="server" ID="ticket_num"></asp:TextBox>
               <asp:RequiredFieldValidator runat="server" ControlToValidate="ticket_num"></asp:RequiredFieldValidator>
            </section>
            <section>
                <asp:ValidationSummary runat="server" ShowSummary ="true" />
            </section>
            <section id ="tickets_summary" runat ="server">
            </section>
            <section>
                <asp:Button runat="server" ID="submit" text="Submit"/>
            </section>
        </div>
    </form>
</body>
</html>
