<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ContosoWeb.Instructor.Instructors1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater runat="server" id="repeater1">
        <HeaderTemplate>
            <table>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Salary</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label runat="server" id="label1" Text='<%# Eval("Id") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="label2" Text='<%# Eval("LastName")%>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" id="label3" Text='<%# Eval("Salary") %>'></asp:Label>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
