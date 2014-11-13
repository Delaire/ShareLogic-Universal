using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Windows.ApplicationModel;
using Windows.System;
using Microsoft.VisualBasic;

namespace ShareLogic_Lib
{
    public class ShareLogic
    {
        private const string CompanyName = "CompanyName";
        private const string InviteFriendsText = "InviteFriendsText";
        private const string ShareViaTwitterText = "ShareViaTwitterText";
        private const string FeedbackEmail = "FeedbackEmail";
       
        public static async void InviteFriends()
        {
            Object[] inviteFriendsText = new Object[] { "", "Invitation from friend", InviteFriendsText };
            Uri uri = new Uri(String.Format("mailto:{0}?subject={1}&body={2}", inviteFriendsText));
            await Launcher.LaunchUriAsync(uri);
        }

        public static async void ShareViaTwitter()
        {
            String str = String.Concat("https://twitter.com/intent/tweet?text=", WebUtility.UrlEncode(ShareViaTwitterText));
            Uri uri = new Uri(str);
            await Launcher.LaunchUriAsync(uri);
        }


        public static async void SendFeedback()
        {
            Object[] major = new Object[] { Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision };

            Object[] feedbackEmail = new Object[] { FeedbackEmail, null, null };
            Object[] applicationFullTitle = new Object[] { String.Format("{0}.{1}.{2}.{3}", major) };
            feedbackEmail[1] = String.Format("{0}, Feedback, Windows Store", applicationFullTitle);
            feedbackEmail[2] = "Description of a problem goes here.";
            Uri uri = new Uri(String.Format("mailto:{0}?subject={1}&body={2}", feedbackEmail));
            await Launcher.LaunchUriAsync(uri);
        }

        public static async void ShowMoreApps()
        {
            Uri uri = new Uri(String.Concat("ms-windows-store:Search?query=", CompanyName));
            await Launcher.LaunchUriAsync(uri);
        }

        public static async void ShowReviewTask()
        {
            Uri uri = new Uri(String.Concat("ms-windows-store:REVIEW?PFN=", Package.Current.Id.FamilyName));
            await Launcher.LaunchUriAsync(uri);
        }
    }
}