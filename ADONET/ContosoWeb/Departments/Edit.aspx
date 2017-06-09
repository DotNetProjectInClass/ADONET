<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ContosoWeb.Departments.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="form-group">
                <span style='color:red; float: left; margin-right:4px; margin-top:3px;'> * </span>
                <label>Name </label>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <span style='color:red; float: left; margin-right:4px; margin-top:3px;'> * </span>
                <label>Budget </label>
                <asp:TextBox runat="server" ID="txtBudget" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtBudget" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <span style='color:red; float: left; margin-right:4px; margin-top:3px;'> * </span>
                <label>Start Date</label>
                <asp:TextBox ID="txtStartDate" runat="server"  CssClass="form-control" placeholder="mm/dd/yyyy"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Hire date should not be empty." Display="Dynamic" ControlToValidate="txtStartDate"></asp:RequiredFieldValidator>                                      
                <asp:RegularExpressionValidator runat="server" ErrorMessage="Format must be mm/dd/yyyy" Display="Dynamic" ControlToValidate="txtStartDate" ValidationExpression="(^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$)"></asp:RegularExpressionValidator>              
            </div>
            <div class="form-group">
                <span style='color:red; float: left; margin-right:4px; margin-top:3px;'> * </span>
                <label>Instructor</label>
                <asp:DropDownList runat="server" id="ddlInstructor" CssClass="form-control"/>
            </div>
            <div class="form-group">
                <asp:Button runat="server" CssClass="btn btn-default" ID="btnSave" OnClick="btnSave_OnClick" Text="Save" />
                <asp:Button runat="server" CssClass="btn btn-default" ID="btnCancel" OnClick="btnCancel_OnClick" Text="Cancel" />

            </div>
        </div>
        
    </div>
</asp:Content>
