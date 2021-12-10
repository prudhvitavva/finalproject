<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="finalproject2._Contact" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center;">Welcome to Best State DNA</h1>
    <h4 style="text-align:center;">Create your account.</h4>
    <div style="text-align:center;">
        <label for="fname">First Name:</label><br>
        <input aspx="text" id="fname" name="fname" placeholder="First name" style="text-align:left;" required><br>
        <label for="lname">Last Name:</label><br>
        <input type="text" id="lname" name="lname" placeholder="Last name" required><br>
        <label for="email">Email:</label><br>
        <input type="email" id="email" name="email" placeholder="name@host.com" autocapitalize="none" required><br>
        <label for="username">Username</label><br>
        <input type="text" id="username" name="username" placeholder="Username" autocapitalize="none" required><br>
        <label for="passwrd">Password:</label><br>
        <input type="password" id="passwrd" name="passwrd" placeholder="Password" min="5" required><br><br>
        <asp:Button type="submit" id="button1" runat="server" Text="Create Account" OnClick="button1_Click"/><br><br>
       
    </div>
        <p style="text-align:center;">
            <span>Already have an account?</span>
            <a href="https://localhost:44353/Login">Log in.</a>
        </p>
</asp:Content>
