<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="GolfClub.CreateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
        Name :
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        Gender :
        <asp:DropDownList ID="drpGender" runat="server">
            <asp:ListItem Selected="True" Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:DropDownList>
        <br />
        Membership Fee :
        <asp:TextBox ID="txtfees" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
    </form>
</body>
</html>
