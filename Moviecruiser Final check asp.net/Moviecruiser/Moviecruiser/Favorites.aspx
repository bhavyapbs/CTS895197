<%@ Page Title="" Language="C#" MasterPageFile="~/MovieAdmin.Master" AutoEventWireup="true" CodeBehind="Favorites.aspx.cs" Inherits="Moviecruiser.WebForm7" %>
<%@ Register Src="~/HeaderCustomer.ascx" TagPrefix="custh" TagName="head" %>
<%@ Register Src="~/FooterAdmin.ascx" TagPrefix="adminf" TagName="foot" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <custh:head ID="h" runat="server" ></custh:head>
     <asp:Panel ID="notification" visible="false" runat="server" Font-Bold="True" Font-Size="30px" ForeColor="#33CC33">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Movie Removed from Favorites successfully<br />
         <br />
      </asp:Panel>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="None" CellPadding="5" CellSpacing="2" GridLines="None"  HorizontalAlign="Center" Font-Size="Medium" Width="774px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  >
         <Columns>
            
               <asp:BoundField HeaderText="Title" DataField="Title" />
               <asp:BoundField HeaderText="BoxOffice" DataField="BoxOffice" />
             <asp:BoundField HeaderText="Genre" DataField="Genre" />
              <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\Favorites.aspx?id={0}&showpanel=true"
            Text="Delete"
            HeaderText=""/>
        </Columns>

         <HeaderStyle HorizontalAlign="Left" />
      
    </asp:GridView>
      <p style="text-indent: 200px; font-weight: bold; font-size: small;">No of Favorites: <asp:Label ID="NofFavorites" runat="server"></asp:Label></p>
        <adminf:foot ID="f" runat="server"></adminf:foot> 
</asp:Content>
