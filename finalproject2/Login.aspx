<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="finalproject2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center;">Welcome to Best State DNA</h1>
    <h4 style="text-align:center;">Log in with your email and password.</h4>
    <div style="text-align:center;">
        <label for="email">Email:</label><br>
        <input type="email" id="email" name="email" placeholder="name@host.com" autocapitalize="none" required><br>
        <label for="passwrd">Password:</label><br>
        <input type="text" id="passwrd" name="passwrd" placeholder="Password" required><br><br>
        <asp:Button id="button2" runat="server" Text="Login" OnClick="button2_Click"/>
    </div>
    <p style="text-align:center;">
        <span>Need an account?</span>
        <a href="https://localhost:44353/Signup">Sign up</a>
    </p>
</asp:Content>
