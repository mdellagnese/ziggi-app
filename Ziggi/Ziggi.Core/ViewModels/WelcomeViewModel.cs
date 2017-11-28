using MvvmCross.Core.ViewModels;

namespace Ziggi.Core.ViewModels
{
    public class WelcomeViewModel
        : BaseViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
