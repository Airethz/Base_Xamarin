using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base_Xamarin.ViewModels
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using Base_Xamarin.Helpers;
    using Base_Xamarin.Models;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class ListViewPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;

        public ObservableCollection<Language> LanguageData { get; set; } = new ObservableCollection<Language>();

        public ListViewPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            SampleDataHelper sampleDataHelper = new SampleDataHelper();

            LanguageData = new ObservableCollection<Language>(sampleDataHelper.GetLanguages());
        }

    }
}
