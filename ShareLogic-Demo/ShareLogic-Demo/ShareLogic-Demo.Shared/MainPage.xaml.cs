using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using ShareLogic_Lib;

namespace ShareLogic_Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ///Examples of how you can use the lib:
            
            //invite your friends to use the app
            ShareLogic.InviteFriends();

            //Send feedback back to the developer
            ShareLogic.SendFeedback();

            //share app on twitter
            ShareLogic.ShareViaTwitter();

            //show other apps developed by the developer 
            ShareLogic.ShowMoreApps();

            //review the app
            ShareLogic.ShowReviewTask();

           
        }
    }
}
