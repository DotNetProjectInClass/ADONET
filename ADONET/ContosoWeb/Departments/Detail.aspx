<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="ContosoWeb.Departments.DepartmentDetail1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="form-group">
                <label>Name</label>
                <asp:Label runat="server" Text="" id="txtName"></asp:Label>
            </div>
            <div class="form-group">
                <label>Budget</label>
                <asp:Label runat="server" Text="" id="txtBudget"></asp:Label>
            </div>
            <div class="form-group">
                <label>Instructor</label>
                <asp:Label runat="server" Text="" id="txtInstructor"></asp:Label>
            </div>
            <div class="form-group">
                <label>Start Date</label>
                <asp:Label runat="server" Text="" id="txtStartDate"></asp:Label>
            </div>
            <div class="form-group">
                <label>Created Date</label>
                <asp:Label runat="server" Text="" id="txtCreatedDate"></asp:Label>
            </div>
            <div class="form-group">
                <label>Created By</label>
                <asp:Label runat="server" Text="" id="txtCreatedBy"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
