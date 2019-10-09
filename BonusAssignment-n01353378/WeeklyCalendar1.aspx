<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeeklyCalendar1.aspx.cs" Inherits="BonusAssignment_n01353378.WeeklyCalendar1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p>Select your scheduled study days:</p>
            <asp:CheckBoxList runat="server" ID="work_days">
                <asp:ListItem Value="monday">Monday</asp:ListItem>
                <asp:ListItem Value="tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="friday">Friday</asp:ListItem>
                <asp:ListItem Value="saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
            <div id="weeklyworkcalendar_summary" runat="server"></div>
            <asp:Button runat="server" Text="Submit"/>
        </div>
    </form>
</body>
</html>
