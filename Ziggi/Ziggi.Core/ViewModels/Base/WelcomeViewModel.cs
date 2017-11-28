using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;

namespace Ziggi.Core.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }
      
        public MvxCommand GoToMainPageCommand
        {
            get { return new MvxCommand(() => _navigationService.Navigate<MainViewModel>()); }
        }
    }
}
