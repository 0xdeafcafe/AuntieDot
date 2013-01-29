<%@ Page Title="Halo 4 Stats API" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AuntieDot.UI.Web.Default" %>
<asp:Content ContentPlaceHolderID="CssContent" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="JavascriptContent" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContent" runat="server">
	<div class="page">
		<div class="container">
			<header class="jumbotron" id="overview">
				<div class="row">
					<div id="header_logo"></div>
				</div>
			</header>

			<section class="seperator-horizontal"></section>

			<section id="api">
				<div class="user-interaction">
					<div class="interaction-dev">
						<div class="header">developers</div>
			
						<div class="auntie-dot-static-1 auntie-icon"></div>

						<div class="dev-eye-candy">
							<button class="btn btn-primary" type="button" onclick="launchApiPage();">Access Developer Wiki</button>
						</div>
					</div>
					<div class="seperator-vertical seperator"></div>
					<div class="interaction-user">
						<div class="header">api example</div>
			
						<div class="auntie-dot-static-3 auntie-icon"></div>

						<div class="user-gt-search">
							<input id="gamertag" type="text" value="AuntieDot Test" /><br />
							<button class="btn btn-primary" type="submit" onclick="launchServiceRecord();">Get Service Record</button>
						</div>
					</div>
		
					<div class="cleaner"></div>
				</div>
			</section>
			
			<section class="seperator-horizontal" style="margin-bottom: 50px;"></section>
		</div>
	</div>
</asp:Content>
<asp:Content ContentPlaceHolderID="JavascriptInlineContent" runat="server">
	<script>
		function launchApiPage() {
			window.location = "http://api.auntiedot.net";
		}

		function launchServiceRecord() {
			var gt = $('#gamertag').attr('value');

			window.location = "ServiceRecord/" + gt;
		}
	</script>
</asp:Content>
