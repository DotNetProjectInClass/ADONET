<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ContosoWeb.Instructor.Instructors1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <b>Instructor List </b> <asp:Button runat="server" Text="Add New" OnClick="OnClick" style="margin-top: 7px;"/>
    <asp:Repeater runat="server" id="repeaterInstructor"  OnItemCommand="repeaterInstructor_OnItemCommand">
      
        <HeaderTemplate>
            <table class="table table-bordered" style="margin-top: 5px;">
            <tr>
                <%--<th>Id</th>--%>
                <th>First Name</th>
                <th>Middle Name</th>
                <th>Last Name</th>
                <th>Hire Date</th>
                <th>Button</th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
           
                <td>
                    <asp:Label runat="server" id="firstName" Text='<%# Eval("FirstName")%>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="middleName" Text='<%# Eval("MiddleName") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="lastName" Text='<%# Eval("LastName") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="hireDate" Text='<%# Eval("HireDate") %>'></asp:Label>
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
