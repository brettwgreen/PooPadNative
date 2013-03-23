using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PooPadNative.Resources;

namespace PooPadNative
{
    public partial class MainPage : PhoneApplicationPage
    {
        bool _isNewPageInstance = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            _isNewPageInstance = true;

            // Set the event handler for when the application data object changes.
            (Application.Current as PooPadNative.App).ApplicationDataObjectChanged +=
                          new EventHandler(MainPage_ApplicationDataObjectChanged);

            
        }

        // The event handler called when the ApplicationDataObject changes.
        void MainPage_ApplicationDataObjectChanged(object sender, EventArgs e)
        {
            // Call UpdateApplicationData on the UI thread.
            Dispatcher.BeginInvoke(() => UpdateApplicationDataUI());
        }

        void UpdateApplicationDataUI()
        {

        }


        private void btnAddBaby_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageAddBaby.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}