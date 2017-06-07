<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInstructor.aspx.cs" Inherits="ContosoWeb.Instructor.AddInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />    
    <link href="../Scripts/jquery-ui.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../Scripts/jquery-ui.min.js"></script>    
    <script src="../Scripts/bootstrap.min.js"></script>

    <title></title>
    
</head>
<body>
<div class="row">
    <div class="col-md-4"></div>
    <div class="col-md-4">
        <form id="form1" runat="server">
       
            <div class="form-group" style="margin-left: 10px;">
                <label for="form1">First Name </label>
                <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" Display="Dynamic" ErrorMessage="First Name should not be empty." ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Last Name </label>
                <asp:TextBox runat="server" ID="txtLastName"  CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" Display="Dynamic" ErrorMessage="Last Name should not be empty." ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
           
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Middle Name</label>
                <asp:TextBox runat="server" ID="txtMiddleName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Date Of Birth</label>
                <asp:TextBox ID="txtDateOfBirth" runat="server"  CssClass="form-control" placeholder="dd/mm/yyyy"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ErrorMessage="Format must be dd/mm/yyyy" Display="Dynamic" ControlToValidate="txtDateOfBirth" ValidationExpression="(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)"></asp:RegularExpressionValidator>              
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Hire Date</label>
                <asp:TextBox ID="txtHireDate" runat="server"  CssClass="form-control" placeholder="dd/mm/yyyy"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ErrorMessage="Format must be dd/mm/yyyy" Display="Dynamic" ControlToValidate="txtHireDate" ValidationExpression="(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)"></asp:RegularExpressionValidator>              
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Email </label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email should be in a validate format." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Email should not be empty." Display="Dynamic" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>                          
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Phone Number</label>
                <asp:TextBox runat="server" ID="txtPhone" CssClass="form-control" placeholder="000-000-0000"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtPhone" Display="Dynamic" ErrorMessage="Phone number should be in a validate format." ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Phone number should not be empty." Display="Dynamic" ControlToValidate="txtPhone"></asp:RequiredFieldValidator>                          
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>SSN</label>
                <asp:TextBox runat="server" ID="txtSSN" CssClass="form-control" placeholder="000-00-0000"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtSSN" Display="Dynamic" ErrorMessage="SSN should be in a validate format." ValidationExpression="\d{3}-\d{2}-\d{4}" ></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="SSN should not be empty." Display="Dynamic" ControlToValidate="txtSSN"></asp:RequiredFieldValidator>                          
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>State</label>
                <asp:DropDownList runat="server" id="ddlState" CssClass="form-control"/>
            </div>
            <div class="form-group"style="margin-left: 10px;">
                <label>Salary</label>
                <asp:TextBox runat="server" ID="txtSalary" CssClass="form-control"></asp:TextBox>
                <%--<asp:RegularExpressionValidator runat="server" ControlToValidate="txtSalary" Display="Dynamic" ErrorMessage="Salary should be in a validate format." ValidationExpression="" ></asp:RegularExpressionValidator>
               --%> 
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Salary should not be empty." Display="Dynamic" ControlToValidate="txtSalary"></asp:RequiredFieldValidator>                          
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