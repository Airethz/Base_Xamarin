using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base_Xamarin.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class PropertyChangedPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public DelegateCommand SubmitCommand { get; set; }
        public string UserName { get; set; }
        public string OnChangeUserName { get; set; }
        public string Result { get; set; }

        public PropertyChangedPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            SubmitCommand = new DelegateCommand(() =>
            {
                Result = UserName;
            });
        }
        public void OnUserNameChanged()
        {
            OnChangeUserName = UserName;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
