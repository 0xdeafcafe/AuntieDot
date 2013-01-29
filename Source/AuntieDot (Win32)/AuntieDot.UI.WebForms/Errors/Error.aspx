<%@ Page Title="" Language="C#" MasterPageFile="~/Error.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="AuntieDot.UI.Web.Errors.Error" %>
<asp:Content ContentPlaceHolderID="ErrorTitle" runat="server">
	Error 404
</asp:Content>
<asp:Content ContentPlaceHolderID="ErrorDesc" runat="server">
	HTTP request failed! HTTP/1.1 404 Not Found.
</asp:Content>
