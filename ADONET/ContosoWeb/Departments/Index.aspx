
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ContosoWeb.Departments.Departments1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <b>Department List </b> <asp:Button runat="server" Text="Add New" OnClick="OnClick" style="margin-top: 7px;"/>
    <asp:Repeater runat="server" id="repeaterDepartment"  OnItemCommand="repeaterDepartment_OnItemCommand">
      
        <HeaderTemplate>
            <table class="table table-bordered" style="margin-top: 5px;">
            <tr>
                <%--<th>Id</th>--%>
                <th>Name</th>
                <th>Budget</th>
                <th>Instructor</th>
                <th>Button</th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
               <%-- <td>
                    <asp:Label runat="server" id="label1" Text='<%# Eval("Id") %>'></asp:Label>
                </td>--%>
                <td>
                    <asp:Label runat="server" id="label2" Text='<%# Eval("Name")%>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="label3" Text='<%# Eval("Budget") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="instructor" Text='<%# Eval("InstructorName") %>'></asp:Label>
                </td>
                <td>
                    <asp:Button runat="server" Text="Detail" CommandName="Detail" CommandArgument='<%# Eval("Id") %>'/>
                    <asp:Button runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("Id") %>'/>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
