<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="ContosoWeb.Department.AddDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
   <title></title>
</head>
<body>
<div class="row">
    <div class="col-md-4">
        <form id="form1" runat="server">
       
            <div class="form-group" style="margin-left: 10px;">
                <label for="form1">Name </label>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Budget </label>
                <asp:TextBox runat="server" ID="txtBudget" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Instructor </label>
                <asp:TextBox runat="server" ID="txtInstructorId" CssClass="form-control"></asp:TextBox>
            </div>
            <%-- <label>Row Version: </label><asp:TextBox runat="server" id="txtRowVersion"></asp:TextBox>
            --%>
            <div class="form-group"style="margin-left: 10px;">
                <asp:Button runat="server" CssClass="btn btn-default" ID="btnSave" OnClick="btnSave_OnClick" Text="Save" />

            </div>
    
        </form>
    </div>
</div>
    
</body>
</html>
