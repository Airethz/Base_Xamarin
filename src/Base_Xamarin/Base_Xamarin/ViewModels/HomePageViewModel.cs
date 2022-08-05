﻿using Prism.Commands;
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
                        await navigationService.NavigateAsync("GridSamplePage");
                        break;
                    case "ScrollView":
                        await navigationService.NavigateAsync("ScrollViewPage");
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
