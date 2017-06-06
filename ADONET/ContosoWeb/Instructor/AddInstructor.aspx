<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInstructor.aspx.cs" Inherits="ContosoWeb.Instructor.AddInstructor" %>

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
                <label for="form1">First Name </label>
                <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="First Name should not be empty." ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Last Name </label>
                <asp:TextBox runat="server" ID="txtLastName" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Last Name should not be empty." ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
           
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Middle Name</label>
                <asp:TextBox runat="server" ID="txtMiddleName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Email </label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="Email should be in a validate format." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Email should not be empty." ControlToValidate="txtEmail"></asp:RequiredFieldValidator>           
               
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>State</label>
                <asp:DropDownList runat="server" id="ddlState"/>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <asp:Button runat="server" CssClass="btn btn-default" ID="btnSave" OnClick="btnSave_OnClick" Text="Save" />
                <asp:Button runat="server" CssClass="btn btn-default" ID="btnCancel" OnClick="btnCancel_OnClick" Text="Cancel" CausesValidation="False" />
            </div>
    
        </form>
    </div>
</div>
</body>
</html>
