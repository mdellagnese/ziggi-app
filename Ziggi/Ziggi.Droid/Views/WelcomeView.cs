using Android.App;
using Android.OS;

namespace Ziggi.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class WelcomeView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.WelcomeView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
