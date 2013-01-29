using AuntieDot.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AuntieDot.Core.Helpers;

namespace AuntieDot.UI.WinForms
{
    public partial class Form1 : Form
    {
        private AuntieDotManager _dot;

        public Form1()
        {
            InitializeComponent();
        }


        private async void btnDoAuth_Click(object sender, EventArgs e)
        {
            var wlidtoken           = await WLIDAuthentication.RequestToken(txtEmail.Text, txtPassword.Text);                   UpdateStatus("WLID OAuth Token Generated");
            txtOAuthToken.Text      = wlidtoken.AccessToken;

            var spartanToken        = await SpartanAuthentication.RequestToken(wlidtoken.AccessToken);                          UpdateStatus("Spartan Token Generated");
            txtSpartanToken.Text    = spartanToken.SpartanToken;

            _dot                    = new AuntieDotManager(spartanToken.SpartanToken, spartanToken.UserInformation.Gamertag);   UpdateStatus("AuntieDot Initalized");
            
            await _dot.GetServicesListAsync();

            lbServices.Items.Clear();
            foreach (var service in _dot.ServicesList.ServiceList)
                lbServices.Items.Add(service.Value);
            UpdateStatus("Services List Recieved");

            txtHeaders.Text = string.Format("X-343-Authorization-WLID: v1={0}\r\nX-343-Authorization-Spartan: {1}",
                                            wlidtoken.AccessToken, spartanToken.SpartanToken);
            UpdateStatus("Populated Headers");
        }
        private async void btnRequestToken_Click(object sender, EventArgs e)
        {
            SpartanAuthentication.Token tok;

            if (txtSpartanToken.Text != "" && cbSkipSTGeneration.Checked)
            {
                tok = new SpartanAuthentication.Token
                {
                    SpartanToken = txtSpartanToken.Text,
                    UserInformation = new SpartanAuthentication.UserInformation
                    {
                        Gamertag = txtGamertag.Text
                    }
                };
                _dot = new AuntieDotManager(tok.SpartanToken, tok.UserInformation.Gamertag);
                UpdateStatus("Inserted Spartan Token");

                return;
            }

            tok = await SpartanAuthentication.RequestToken(txtOAuthToken.Text);
            _dot = new AuntieDotManager(tok.SpartanToken, tok.UserInformation.Gamertag);
            txtSpartanToken.Text = tok.SpartanToken;
            txtGamertag.Text = tok.UserInformation.Gamertag;
            UpdateStatus("Generated Spartan Token");
        }
        private async void btnGetServicesList_Click(object sender, EventArgs e)
        {
            await _dot.GetServicesListAsync();

            lbServices.Items.Clear();
            foreach (var service in _dot.ServicesList.ServiceList)
                lbServices.Items.Add(service.Value);
            UpdateStatus("Services List Recieved");


            txtHeaders.Text = string.Format("X-343-Authorization-WLID: v1={0}\r\nX-343-Authorization-Spartan: {1}",
                                            txtOAuthToken.Text, txtSpartanToken.Text);
            UpdateStatus("Populated Headers");
        }

        private async void btnGetServiceRecord_Click(object sender, EventArgs e)
        {
            var serviceRecord = await
                    JsonConvert.DeserializeObjectAsync<Models._343.ServiceRecord.ServiceRecordResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetServiceRecord"], txtGamertag.Text));
        }
        private async void btnGetChallenges_Click(object sender, EventArgs e)
        {
            var json = await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetGlobalChallenges"], txtGamertag.Text);

            var challenges = await JsonConvert.DeserializeObjectAsync<Models._343.Challenges.ChallengesResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetGlobalChallenges"], txtGamertag.Text));
        }
        private async void btnGetCommendations_Click(object sender, EventArgs e)
        {
            var commendations = await JsonConvert.DeserializeObjectAsync<Models._343.Commendations.CommendationsResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetCommendations"], txtGamertag.Text));
        }
        private async void btnGetCampaign_Click(object sender, EventArgs e)
        {
            var campaign = await JsonConvert.DeserializeObjectAsync<Models._343.Campaign.CampaignResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetCampaignDetails"], txtGamertag.Text));
        }
        private async void btnGetSpartanOps_Click(object sender, EventArgs e)
        {
            var spartanOps = await JsonConvert.DeserializeObjectAsync<Models._343.SpartanOps.SpartanOpsResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetSpartanOpsDetails"], txtGamertag.Text));
        }
        private async void btnGetCustoms_Click(object sender, EventArgs e)
        {
            var customs = await JsonConvert.DeserializeObjectAsync<Models._343.Customs.CustomsResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetCustomGameDetails"], txtGamertag.Text));
        }
        private async void btnGetWargames_Click(object sender, EventArgs e)
        {
            var wargames = await JsonConvert.DeserializeObjectAsync<Models._343.WarGames.WarGamesResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetWarGameDetails"], txtGamertag.Text));
        }
        private async void btnGetPlaylists_Click(object sender, EventArgs e)
        {
            var playlist = await
                    JsonConvert.DeserializeObjectAsync<Models._343.Playlists.PlaylistsResponse>(
                            await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetPlaylists"], txtGamertag.Text));
        }
        private async void btnGetPlayerCard_Click(object sender, EventArgs e)
        {
            var playerCard = await
                    JsonConvert.DeserializeObjectAsync<Models._343.PlayerCards.PlayerCardResponse>(
                            await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetPlayerCard"], txtGamertag.Text));
        }
        private async void btnGetMetadata_Click(object sender, EventArgs e)
        {
            var metaData = await
                    JsonConvert.DeserializeObjectAsync<Models._343.MetaData.MetaDataResponse>(
                            await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetGameMetadata"], txtGamertag.Text));
        }
        private async void btnGetMatches_Click(object sender, EventArgs e)
        {
            var matches = await
                    JsonConvert.DeserializeObjectAsync<Models._343.Matches.MatchesResponse>(
                            await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetGameHistory"] + string.Format("?count={0}&startat={1}", txtMatchesCount.Text, txtMatchesStartAt.Text), txtGamertag.Text));
        }
        private async void btnGetMatch_Click(object sender, EventArgs e)
        {
            var match = await
                    JsonConvert.DeserializeObjectAsync<Models._343.Match.MatchResponse>(
                            await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetGameDetails"],
                                    txtGamertag.Text, new Dictionary<string, string>() { { "{gameid}", txtMatchID.Text } }));
        }

        private async void btnGetPeronalChallenges_Click(object sender, EventArgs e)
        {
            var personalChallenges = await JsonConvert.DeserializeObjectAsync<Models._343.Challenges.ChallengesResponse>(await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetPlayerChallenges"]));
        }

        private void UpdateStatus(string status)
        {
            lblStatus.Text = string.Format("Status: {0}...", status);
        }

        private async void btnCallSelectedService_Click(object sender, EventArgs e)
        {
            var headers = txtHeaders.Text.Replace("\r", "").Split('\n');

            var headersCorrect = new Dictionary<string, string>();
            foreach(var header in headers)
            {
                if (String.IsNullOrEmpty(header.Trim())) continue;

                var headerIdent = header.Split(':')[0];
                var headerCont = header.Replace(headerIdent, "").Replace(":", "").TrimStart();
                headersCorrect.Add(headerIdent, headerCont);
            }

            txtServiceOutput.Text = await VariousFunctions.SendGetRequestAsync(txtSelectedService.Text, headersCorrect);
        }
        private void lbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedService.Text = lbServices.SelectedItem.ToString();

            txtSelectedService.Text = txtSelectedService.Text
                .Replace("{gamertag}", txtGamertag.Text).Replace("{language}", "en-us").Replace("{game}", "h4");
        }

        private async void btnRapeThemServers_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 1000; i++)
            {
                var metaData = await
                JsonConvert.DeserializeObjectAsync<Models._343.MetaData.MetaDataResponse>(
                        await _dot.CallX343ApiAsync(_dot.ServicesList.ServiceList["GetGameMetadata"], txtGamertag.Text));
            }
        }
    }
}