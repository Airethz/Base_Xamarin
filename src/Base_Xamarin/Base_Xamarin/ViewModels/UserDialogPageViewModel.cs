using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base_Xamarin.ViewModels
{
    using System.ComponentModel;
    using System.Threading.Tasks;
    using Acr.UserDialogs;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class UserDialogPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public DelegateCommand ShowDialogCommand { get; set; }

        public UserDialogPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowDialogCommand = new DelegateCommand(async () =>
            {
                using (IProgressDialog fooIProgressDialog = UserDialogs.Instance.Loading($"等待5秒",
                    null, null, true, MaskType.Black))
                {
                    await Task.Delay(5000);
                }
            });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

    }
}
