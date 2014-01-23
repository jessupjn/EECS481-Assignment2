using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RideBlue.Resources;

namespace RideBlue
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar

            //CancelRide.Opacity = 0;
            //WaitingPos.Opacity = 0;
            //GetARide.Margin = new Thickness(0, 484, 0, 0);

        }

        private void GetARide(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Get Ride Button Pressed");
            NavigationService.Navigate(new Uri("/GetRidePage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void ChekWaitingPosition(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Waiting Position Button Pressed");

        }
        private void CancelYourRide(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Cancel Button Pressed");

        }
        private void SettingsMenu(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Settings Button Pressed");
            NavigationService.Navigate(new Uri("/SettingsMenuPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void HelpMenu(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Help Button Pressed");
        }

    }
}