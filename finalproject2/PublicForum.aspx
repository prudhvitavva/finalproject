<%@ Page Title="Public Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicForum.aspx.cs" Inherits="finalproject2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br />
    <div class="container">
        <asp:GridView ID="GridView2" runat="server"> </asp:GridView>
    </div>
    <div class="container">
        <table>
            <tr>
                <td>
                    <asp:Label ID="label1" runat="server" Text="Add your Rating Below:" Font-Bold="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:label ID="label2" runat="server" Text="Username"></asp:label> 
                </td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:label ID="label3" runat="server" Text="Date (mm/dd/yyyy)"></asp:label> 
                </td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:label ID="label4" runat="server" Text="State"></asp:label> 
                </td>
                <td>
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:label ID="label5" runat="server" Text="Rating (out of 10)"></asp:label> 
                </td>
                <td>
                    <asp:TextBox ID="txtRating" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:button ID="btnAddRating" runat="server" Text="Add Rating" OnClick="btnAddRating_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

