using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.Navigation;

namespace Ziggi.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        protected MainViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public void ShowMenu()
        {
            Console.WriteLine("Entrei aqui - ShomMenu");
        }

        public void ShowHome()
        {
            //ShowViewModel<HomeViewModel>();
            Console.WriteLine("Entrei aqui - ShowHome");
        }

        public void Init(object hint)
        {
            // Can perform Vm data retrival here based on any
            // data passed in the hint object

            // ShowViewModel<SomeViewModel>(new { derp: "herp", durr: "derrrrrr" });
            // public class SomeViewModel : MvxViewModel
            // {
            //     public void Init(string derp, string durr)
            //     {
            //     }
            // }
        }

        public override void Start()
        {
            //base.Start();
        }
    }
}
