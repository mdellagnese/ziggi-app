using MvvmCross.Platform.IoC;
using MvvmCross.Core.ViewModels;

namespace Ziggi.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.WelcomeViewModel>();
        }
    }
}
