<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="ContosoWeb.Departments.AddDepartment" %>

<!DOCTYPE html>
<script src="../Scripts/jquery-1.10.2.min.js"></script>
<script src="../Scripts/bootstrap.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-control">
            <label>Name: </label> <asp:TextBox runat="server" id="txtName" CssClass="form-group"></asp:TextBox>
            <label>Budget: </label> <asp:TextBox runat="server" id="txtBudget"></asp:TextBox>
            <label>Instructor: </label><asp:TextBox runat="server" id="txtInstructorId"></asp:TextBox>
           <%-- <label>Row Version: </label><asp:TextBox runat="server" id="txtRowVersion"></asp:TextBox>
           --%>
            <asp:Button runat="server" id="btnSave" OnClick="btnSave_OnClick" Text="Save"/>
        </div>
    </form>
</body>
</html>
