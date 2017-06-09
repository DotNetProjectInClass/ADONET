<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeBehind="PageLifeCycle.aspx.cs" Inherits="ContosoWeb.PageLifeCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <h3> <%= GetType().Assembly.Location %> </h3>

        <asp:TextBox runat="server" EnableViewState="False"  id="txtName" Text="initialtext"></asp:TextBox> <br/>
        <asp:Label runat="server" id="lblResult"></asp:Label> <br/>
        <%--<input id="txtHtml"/> <br/>--%>
        <asp:Button runat="server" name="bttttt" id="btnSubmit" Text="Submit My Save" OnClick="btnSubmit_OnClick"/>
    </div>
</form>
</body>
</html>