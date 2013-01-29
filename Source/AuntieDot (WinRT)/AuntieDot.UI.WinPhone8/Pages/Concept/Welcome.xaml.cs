using System;
using System.Threading;
using System.Windows;

namespace AuntieDot.UI.WinPhone8.Pages.Concept
{
    public partial class Welcome
    {
        public Welcome()
        {
            InitializeComponent();

            PendingStagePanel.Visibility = Visibility.Collapsed;
        }

        private void btnQuery_Click(object sender, RoutedEventArgs e) { GoToServiceRecord(); }
        private void btnRecent1_Click(object sender, RoutedEventArgs e) { GoToServiceRecord(); }
        private void btnRecent2_Click(object sender, RoutedEventArgs e) { GoToServiceRecord(); }
        private void btnRecent3_Click(object sender, RoutedEventArgs e) { GoToServiceRecord(); }

        public void GoToServiceRecord()
        {
            // Show Pending UI
            ShowPendingUI.Completed += (o, args) =>
                {
                    //Show Processing Animation
                    ProcessingAnimation.Begin();

                    var waitThread = new Thread(() =>
                        {
                            // zzzzz
                            Thread.Sleep(2500);

                            // Go to Service Record
                            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/Concept/ServiceRecord/Hub.xaml", UriKind.Relative))); 
                        });
                    waitThread.Start();

                };
            ShowPendingUI.Begin();
        }
    }
}