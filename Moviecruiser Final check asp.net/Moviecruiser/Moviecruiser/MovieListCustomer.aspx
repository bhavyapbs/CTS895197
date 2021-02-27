<%@ Page Title="" Language="C#" MasterPageFile="~/MovieAdmin.Master" AutoEventWireup="true" CodeBehind="MovieListCustomer.aspx.cs" Inherits="Moviecruiser.WebForm6" %>
<%@ Register Src="~/HeaderCustomer.ascx" TagPrefix="custh" TagName="head" %>
<%@ Register Src="~/FooterAdmin.ascx" TagPrefix="adminf" TagName="foot" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <custh:head ID="h" runat="server" ></custh:head>
    <asp:Panel ID="notification" visible="false" runat="server" ForeColor="#33CC33" Font-Bold="True" Font-Size="30px" Height="89px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Movie added to favorites successfully<br />
        <br />
        <br />
        <br />
     </asp:Panel>
     <br />
     <br />
    <asp:GridView ID="GridView1" runat="server" BorderStyle="None" CssClass="auto-style3" GridLines="None" Height="247px" HorizontalAlign="Center" Width="984px" AutoGenerateColumns="False" CellPadding="2" CellSpacing="3" CaptionAlign="Bottom" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
      
        <Columns>
             <asp:BoundField HeaderText="ID" DataField="Id" />
               <asp:BoundField HeaderText="Title" DataField="Title" />
               <asp:BoundField HeaderText="BoxOffice" DataField="BoxOffice" />
             <asp:BoundField HeaderText="Genre" DataField="Genre" />
               <asp:BoundField HeaderText="Has Teaser" DataField="HasTeaser" />
               <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\MovieListCustomer.aspx?id={0}&showpanel=true"
            Text="AddToFavorite"
            HeaderText="Action" />
        </Columns>
        <HeaderStyle HorizontalAlign="Left" />
    </asp:GridView>
    <adminf:foot ID="f" runat="server"></adminf:foot>  
</asp:Content>


