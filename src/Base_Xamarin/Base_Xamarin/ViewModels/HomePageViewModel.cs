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
    public class HomePageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public DelegateCommand<string> GoPageCommand { get; set; }

        public HomePageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            GoPageCommand = new DelegateCommand<string>(async x =>
            {
                switch (x)
                {
                    case "Grid":
                        await navigationService.NavigateAsync("GridPage");
                        break;
                    case "ScrollView":
                        await navigationService.NavigateAsync("ScrollViewPage");
                        break;
                    case "StackLayout":
                        await navigationService.NavigateAsync("StackLayoutPage");
                        break;
                    case "ListView":
                        await navigationService.NavigateAsync("ListViewPage");
                        break;
                    case "CollectionView":
                        await navigationService.NavigateAsync("CollectionViewPage");
                        break;
                    case "PropertyChanged":
                        await navigationService.NavigateAsync("PropertyChangedPage");
                        break;
                    case "UserDialog":
                        await navigationService.NavigateAsync("UserDialogPage");
                        break;
                    case "圖片":
                        await navigationService.NavigateAsync("ImagePage");
                        break;
                    case "位置":
                        await navigationService.NavigateAsync("LocationPage");
                        break;
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
