<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="finalproject2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Best State DNA</h1>
        <h3>Determined Using an Index For Young People, By Young People</h3>
        <img src="/images/landscape.jpg" height="300" width="600" />
    </div>

    <div class="row">
        <div class="col-md-10">
            <h2>Rankings</h2>
            <p>
                Every state is known for something different. Each state may specialize or excel in a certain area, but these rankings will consider multiple factors to determine where the best place to live is for young people. The metrics that will be taken into consideration include median salary, cost of living, education, crime, COVID, and healthcare. Each metric was weighted differently based on what young people felt was the most important.
            </p>
        </div>
        <div class="col-md-10">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView> 
        </div>
    </div>

</asp:Content>
