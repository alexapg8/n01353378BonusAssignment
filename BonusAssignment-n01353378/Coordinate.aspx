<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate.aspx.cs" Inherits="BonusAssignment_n01353378.Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <section>
            <h1>Set your coordinates:</h1>
            <label>Enter x:</label>
            <asp:TextBox runat="server" ID="coordinate_x"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="coordinate_x" ErrorMessage="Please enter a number that is not 0"></asp:RequiredFieldValidator>
            <label>Enter y:</label>
            <asp:TextBox runat="server" ID="coordinate_y"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="coordinate_y" ErrorMessage="Please enter a number that is not 0"></asp:RequiredFieldValidator>
        </section>
        <section>
                <asp:ValidationSummary runat="server" ShowSummary ="true" />
            </section>
            <div id ="coordinates_summary" runat ="server">
            </div>
            <section>
                <asp:Button runat="server" ID="submit" text="Submit"/>
            </section>
            </div>
    </form>
</body>
</html>
