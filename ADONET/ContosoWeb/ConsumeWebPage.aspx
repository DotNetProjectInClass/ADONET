<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumeWebPage.aspx.cs" Inherits="ContosoWeb.ConsumeWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Number1 :
            <asp:TextBox runat="server" ID="txtNumber1"></asp:TextBox>
            <br/>
            Enter Number 2:
            <asp:TextBox runat="server" ID="txtNumber2"></asp:TextBox>

            <asp:Button runat="server" Text="CallWebServiceAdd" OnClick="btnAddition_OnClick" ID="btnAddition"/>
            <asp:Button runat="server" Text="CallWebServiceSub" OnClick="btnSubstract_OnClick" ID="btnSubstract"/>
            <asp:Button runat="server" ID="CallWCFStudent" Text="Call Student" OnClick="CallWCFStudent_OnClick"/>
        </div>
    </form>
</body>
</html>
