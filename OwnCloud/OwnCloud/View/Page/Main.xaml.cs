﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using OwnCloud.Data;

namespace OwnCloud
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = App.DataContext;
        }

        private void SettingsAccountsTab(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Page/AccountList.xaml", UriKind.Relative));
        }

        private void OpenCalendarTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var currentAccount = ((FrameworkElement) sender).DataContext as Account;

            //Navigate to the calendar page with te userID
            if (currentAccount != null)
                NavigationService.Navigate(new Uri("/View/Page/CalendarMonthPage.xaml?uid=" + String.Format(@"{0:g}", currentAccount.GUID), UriKind.Relative));
        }
    }
}