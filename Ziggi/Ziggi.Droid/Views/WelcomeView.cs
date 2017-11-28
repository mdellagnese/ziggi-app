using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using Ziggi.Core.ViewModels;

namespace Ziggi.Droid.Views
{
    [Activity(
        Label = "Welcome",
        Theme = "@style/MyTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "ziggi.droid.views.WelcomeView"
    )]
    public class WelcomeView : MvxAppCompatActivity<WelcomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //SupportActionBar.SetDisplayHomeAsUpEnabled(false);

            SetContentView(Resource.Layout.WelcomeView);
        }
    }
}
