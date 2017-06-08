<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ContosoWeb.Departments.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="form-group">
                <label>Name </label>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Budget </label>
                <asp:TextBox runat="server" ID="txtBudget" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Instructor</label>
                <asp:DropDownList runat="server" id="ddlInstructor" CssClass="form-control"/>
            </div>
            <div class="form-group">
                <asp:Button runat="server" CssClass="btn btn-default" ID="btnSave" OnClick="btnSave_OnClick" Text="Save" />

            </div>
        </div>
        
    </div>
</asp:Content>
