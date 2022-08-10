using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base_Xamarin.ViewModels
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class CollectionViewPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public ObservableCollection<string> Dogs { get; set; } = new ObservableCollection<string>();

        public CollectionViewPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            List<string> dogs = new List<string> { "邊境牧羊犬", "貴賓犬", "德國牧羊犬", "黃金獵犬", "杜賓犬", 
                "喜樂蒂牧羊犬", "拉布拉多犬", "蝴蝶犬", "羅威那犬", "澳洲牧牛犬" };

            Dogs = new ObservableCollection<string>(dogs);
        }

    }
}
