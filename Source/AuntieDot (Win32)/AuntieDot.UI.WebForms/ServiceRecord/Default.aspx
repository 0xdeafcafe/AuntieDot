<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AuntieDot.UI.Web.ServiceRecord.Default" %>
<asp:Content ContentPlaceHolderID="CssContent" runat="server">
	<link href="/Content/servicerecord.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ContentPlaceHolderID="JavascriptContent" runat="server"></asp:Content>
<asp:Content ContentPlaceHolderID="BodyContent" runat="server">
	<%  if (ServiceRecordResponse != null && ServiceRecordResponse.StatusCode == 1)
		{ %>
	<div class="page-container">
		<div class="row-data row-alpha">
			<div class="row-container">
				<div class="player-visuals">
					<div class="player-image"
						style="background-image: url('<%= PlayerSpartanImage %>');"></div>
					<div class="player-detail-summary">
						<div class="player-gamertag"><%= ServiceRecordResponse.Gamertag %></div>
						<div class="player-servicetag"><%= ServiceRecordResponse.ServiceTag %></div>
						<div class="player-emblem"
							style="background-image: url('<%= PlayerSpartanEmblem %>');"></div>
					</div>
					
					<div class="cleaner"></div>
				</div>
			</div>
		</div>
		<div class="row-data row-delta">
			<div class="row-container">
				<div class="gameplay-summary">
					<div class="gameplay-favourite-weapon">
						<div class="gameplay-favourite-name"><%= ServiceRecordResponse.FavoriteWeaponName %></div>

						<div class="gameplay-favourite-weapon-icon"
							style="background-image: url('<%= PlayerFavWeapon %>');"></div>
					
						<div class="gameplay-favourite-weapon-stats">
							<div class="gameplay-favourite-kill-count"><%= ServiceRecordResponse.FavoriteWeaponTotalKills %></div>
							<div class="gameplay-favourite-kill">kills</div>
						</div>
					</div>
					<div class="gameplay-left">
						<div class="gameplay-favourite-weapon-desc"><span class="semi-bold">DESIGNATION:</span><%= ServiceRecordResponse.FavoriteWeaponDescription.Replace("DESIGNATION:", "") %></div>
					</div>

				
					<div class="cleaner"></div>
				</div>
			</div>
		</div>
		<div class="row-data row-alpha">
			<div class="row-container">
				<div class="stats-overview">
					<div class="stats-rank">
						<div class="stats-rank-icon"
							style="background-image: url('<%= PlayerCurrentRank %>');"></div>
						<div class="stats-spec-name"><%= PlayerCurrentSpecialization.Name.ToUpper() %></div>
						<div class="rank-progression">
							<%
								float a = ServiceRecordResponse.NextRankStartXP - ServiceRecordResponse.RankStartXP;
								float b = ServiceRecordResponse.XP - ServiceRecordResponse.RankStartXP;
								a = a <= 0 ? 1 : a;
								b = b <= 0 ? 1 : b;
								b = ((a - b)/a)*100;


								if (ServiceRecordResponse.NextRankStartXP == 0)
									b = 0;

								var progression_togo = (b)*2.5;
								var progression_done = (100 - b)*2.5;
%>
							
							<div class="progression-done"
								style="width: <%= progression_done %>px"></div>
							<div class="progression-togo"
								style="width: <%= progression_togo %>px"></div>
							
							<div class="cleaner"></div>
						</div>
						<div class="rank-xp-info">
							<%
								if (ServiceRecordResponse.NextRankStartXP == 0)
								{
%>max rank<%
								}
								else
								{
%>
									<%= ServiceRecordResponse.XP - ServiceRecordResponse.RankStartXP %>xp/<span><%= ServiceRecordResponse.NextRankStartXP - ServiceRecordResponse.RankStartXP %>xp</span>
									<%
								}
%>
						</div>
					</div>
					<div class="seperator-vertical seperator"></div>
					<div class="stats-summary">
						<div class="stats-small">
							<div class="stat-header">gametime</div>
							<div class="stat-data"><%= ServiceRecordResponse.TotalGameplay %></div>

							<div class="stat-header">medals earned</div>
							<div class="stat-data"><%= ServiceRecordResponse.TotalMedalsEarned %></div>

							<div class="stat-header">games played</div>
							<div class="stat-data"><%= ServiceRecordResponse.TotalGamesStarted %></div>
						</div>
						<div class="stats-large-sp">
							<div class="stat-large-placement">
								<div class="stat-large-header"><%= ServiceRecordResponse.SpartanPoints %></div>
								<div class="stat-large-data">sp</div>
							</div>
						</div>
						<div class="cleaner"></div>
					</div>
					<div class="cleaner"></div>
				</div>
			</div>
		</div>
		<div class="row-data row-delta">
			<div class="row-container">
				<div class="medals-overview">
					<%
						if (ServiceRecordResponse.TopMedals.Count == 0)
						{
%>
						<div class="medals-error">You haven't earned any medals yet :(. Go play some halo, kid.</div>
						<%
						}
						else
						{
%>
						<div class="medals-title">top medals</div>
						<%

							foreach (var medal in ServiceRecordResponse.TopMedals.OrderByDescending(m => m.TotalMedals))
							{
								var imageUrl = Dot.CreateUrlFromObject(medal.ImageUrl, "medium");

%>
							<div class="medal-entry" id="medal-<%= medal.Id %>"
								style="background-image: url('<%= imageUrl %>');">
								<div class="medal-count"><%= medal.TotalMedals %></div>
							</div>
							<%
							}

%>
						<div class="cleaner"></div>
						<%
						}
%>
				</div>
			</div>
		</div>
		<div class="row-data row-alpha">
			<div class="row-container">
				<div class="page-summary">
					<div class="dev-outro">
						<div class="outro-header">Developers:</div>
						<div class="outro-body">This is just a very, very small example of what can be done using the Halo 4 API (half the content of 1 request). For more information on using the API, <a href="http://api.auntiedot.net/">come over here</a>. </div>
					</div>
					<div class="nub-outro">
						<div class="outro-header">Users:</div>
						<div class="outro-body">This is just a mini-stat site to show off what can be done. For a list of better and more complete websites/apps, <a href="http://api.auntiedot.net/index.php?title=Implementations">check me out ;)</a>.</div>
					</div>
					<div class="foot-note">
						<span class="semi-bold">*</span>stats are only updated every 3 hours. Stops our bandwidth going to high, or us savaging 343's servers too badly.
					</div>
				</div>
			</div>
		</div>
	</div>
	<%
		}%>
</asp:Content>
<asp:Content ContentPlaceHolderID="JavascriptInlineContent" runat="server"></asp:Content>