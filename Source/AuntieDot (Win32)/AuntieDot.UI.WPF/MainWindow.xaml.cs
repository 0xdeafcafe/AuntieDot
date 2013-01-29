using System.Windows;
using AuntieDot.Authentication;
using Newtonsoft.Json;

namespace AuntieDot.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AuntieDotManager _auntieDotManager;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            var wlidToken = await WLIDAuthentication.RequestToken(txtEmail.Text, txtPassword.Password);
            var spartanToken = await SpartanAuthentication.RequestToken(wlidToken.AccessToken);
            _auntieDotManager = new AuntieDotManager(spartanToken.SpartanToken, spartanToken.UserInformation.Gamertag);
            await _auntieDotManager.GetServicesListAsync();

            var data = JsonConvert.DeserializeObject<Models._343.WarGames.WarGamesResponse>(
                await _auntieDotManager.CallX343ApiAsync(_auntieDotManager.ServicesList.ServiceList["GetWarGameDetails"]));

            MessageBox.Show("Best Game Total Kills: " + data.BestGameTotalKills, "swag", MessageBoxButton.OK);
        }
    }
}