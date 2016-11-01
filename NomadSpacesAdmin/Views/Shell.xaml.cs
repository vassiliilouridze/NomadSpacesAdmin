using System;
using System.ComponentModel;
using System.Linq;
using Template10.Common;
using Template10.Controls;
using Template10.Services.NavigationService;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NomadSpacesAdmin.Views
{
    public sealed partial class Shell : Page
    {
        public static HamburgerMenu HamburgerMenu => Instance.MyHamburgerMenu;

        public static Shell Instance { get; set; }
        private static WindowWrapper Window { get; set; }

        public Shell(INavigationService navigationService)
        {
            Instance = this;
            this.InitializeComponent();

            // setup for static calls
            Window = WindowWrapper.Current();
            MyHamburgerMenu.NavigationService = navigationService;

            // any nav change, reset to normal
            navigationService.FrameFacade.Navigated += (s, e) =>
                LoginModal.IsModal = false;
        }

        #region Login

        private void LoginTapped(object sender, RoutedEventArgs e)
        {
            LoginModal.IsModal = true;
        }

        private void LoginHide(object sender, System.EventArgs e)
        {
            LoginButton.IsEnabled = true;
            LoginModal.IsModal = false;
        }

        private void LoginLoggedIn(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = false;
            LoginModal.IsModal = false;
        }

        #endregion
    }
}

