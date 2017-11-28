using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using Ziggi.Core.ViewModels;

namespace Ziggi.Droid.Views
{
    [Activity(
        Label = "Main Activity",
        Theme = "@style/MyTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "ziggi.droid.views.MainView"
    )]
    public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        public DrawerLayout DrawerLayout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            DrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            if (bundle == null)
                ViewModel.ShowMenu();
        }
    }
}