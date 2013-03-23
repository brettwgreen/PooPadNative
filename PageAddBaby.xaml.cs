using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PooPadNative
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();

        }

        private void btnSaveBaby_Click(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            var babies = app.ApplicationDataObject;
            babies.Add(new Baby(txtBabyName.Text));
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}