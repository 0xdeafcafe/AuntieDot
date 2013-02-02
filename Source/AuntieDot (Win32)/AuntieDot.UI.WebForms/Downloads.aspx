<%@ Page Title="Downloads" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Downloads.aspx.cs" Inherits="AuntieDot.UI.Web.Downloads" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CssContent" runat="server">
	<link href="/Content/download.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="JavascriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="page">
		<div class="container">
			<header class="jumbotron" id="overview">
				<div class="row">
					<div id="header_logo"></div>
				</div>
			</header>

			<section class="seperator-horizontal"></section>

			<section id="download">
				<div class="user-interaction">
					<div class="interaction-down">
						<div class="header">downloads</div>
						
						<p>Thnks ft th Mmrs <br /><br />Downloads for the Source and Binaries (and NuGet!) of the project are below. So get downloading, developing and show 343 a good time!</p>

						<div class="down-eye-candy">
							<button class="btn btn-primary btn-download" type="button" onclick="launchNuGet();">Visit NuGet</button> <br />
							<button class="btn btn-primary btn-download" type="button" onclick="launchGitHub();">Visit GitHub</button> <br />
						</div>
					</div>
					<div class="cleaner"></div>
				</div>
			</section>
			
			<section class="seperator-horizontal" style="margin-bottom: 50px;"></section>
		</div>
	</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="JavascriptInlineContent" runat="server">
	<script>
		function launchNuGet() {
			window.target = "_blank";
			window.location = "http://nuget.org/packages/AuntieDot/";
		}
		function launchGitHub() {
			window.target = "_blank";
			window.location = "https://github.com/Xerax/AuntieDot";
		}
	</script>
</asp:Content>