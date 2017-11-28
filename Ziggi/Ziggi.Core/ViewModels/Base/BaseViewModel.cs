using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace Ziggi.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        protected readonly  IMvxNavigationService _navigationService;

        protected BaseViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
