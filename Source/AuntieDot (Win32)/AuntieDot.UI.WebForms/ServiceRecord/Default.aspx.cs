using System.Linq;
using AuntieDot.Models._343.ServiceRecord;
using AuntieDot.Models._343.Common;
using AuntieDot.X343Service;
using Newtonsoft.Json;
using System;
using AuntieDot.UI.Web.Connector;

namespace AuntieDot.UI.Web.ServiceRecord
{
	public partial class Default : System.Web.UI.Page
	{
		public AuntieDotManager Dot;
		public ServiceRecordResponse ServiceRecordResponse;
		public string PlayerSpartanImage;
		public string PlayerSpartanEmblem;
		public string PlayerFavWeapon;
		public string PlayerCurrentRank;
		public string PlayerNextRank;
		public Specialization PlayerCurrentSpecialization;

		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				var gamertag = Request.QueryString["gt"];
				if (gamertag == null || gamertag.Trim() == "")
				{
					Response.Redirect("/", false);
					return;
				}

				// Get Player Service Record
				Dot = new AuntieDotManager("", gamertag);

				var services = ServicesCache.GetServicesList();
				if (services == null)
				{
					// nothing in cache, or it has expires. regardless, lets do this
					services = Dot.CallX343Api(ServicesList.ServicesListUrl);

					ServicesCache.SetServicesList(services);
					Dot.SetServicesList(services);
				}
				else
					Dot.GetServicesList();

				var playerData = PlayersCache.GetPlayerData(gamertag);
				if (playerData == null)
				{
					// nothing in cache, or it has expires. regardless, lets do this
                    playerData = Dot.CallX343Api(Dot.ServicesList.ServiceList["GetServiceRecord"]);
					PlayersCache.SetPlayerData(playerData, gamertag);
				}
				else
                    playerData = Dot.CallX343Api(Dot.ServicesList.ServiceList["GetServiceRecord"]);

				ServiceRecordResponse = JsonConvert.DeserializeObject<ServiceRecordResponse>(playerData);

				if (ServiceRecordResponse.StatusCode != 1)
				{
					Response.Redirect("/ServiceRecord/Error/GamertagNotFound", false);
					return;
				}

				// Prep
				PlayerSpartanImage = Dot.ServicesList.ServiceList["GetSpartanImage"]
					.Replace("{gamertag}", ServiceRecordResponse.Gamertag)
					.Replace("{game}", "h4")
					.Replace("{pose}", "fullbody")
					.Replace("{size}", "large");
				PlayerSpartanEmblem = Dot.CreateUrlFromObject(ServiceRecordResponse.EmblemImageUrl, "120");
				PlayerFavWeapon = Dot.CreateUrlFromObject(ServiceRecordResponse.FavoriteWeaponImageUrl, "large");
				PlayerCurrentRank = Dot.CreateUrlFromObject(ServiceRecordResponse.RankImageUrl, "large");
				PlayerNextRank = Dot.CreateUrlFromObject(ServiceRecordResponse.NextRankImageUrl, "large");
				PlayerCurrentSpecialization = ServiceRecordResponse.Specializations.Single(specialization => specialization.IsCurrent);

				Title = ServiceRecordResponse.Gamertag + "'s Service Record";
			}
			catch (Exception ex)
			{
				Response.Redirect("/ServiceRecord/Error/Exception", false);
			}
		}
	}
}