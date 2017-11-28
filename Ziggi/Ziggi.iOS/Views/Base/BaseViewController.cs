using MvvmCross.iOS.Views;
using Ziggi.Core.ViewModels;

namespace Ziggi.iOS.Views
{
    public class BaseViewController<TViewModel> : MvxViewController where TViewModel : BaseViewModel
    {
    }
}
