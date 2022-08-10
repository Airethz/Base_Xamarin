using Base_Xamarin.ViewModels;
using Base_Xamarin.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Base_Xamarin
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MDPage/NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<ScrollViewPage, ScrollViewPageViewModel>();
            containerRegistry.RegisterForNavigation<MDPage, MDPageViewModel>();
            containerRegistry.RegisterForNavigation<GridPage, GridPageViewModel>();
            containerRegistry.RegisterForNavigation<ListViewPage, ListViewPageViewModel>();
            containerRegistry.RegisterForNavigation<CollectionViewPage, CollectionViewPageViewModel>();
            containerRegistry.RegisterForNavigation<StackLayoutPage, StackLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<PropertyChangedPage, PropertyChangedPageViewModel>();
            containerRegistry.RegisterForNavigation<UserDialogPage, UserDialogPageViewModel>();
            containerRegistry.RegisterForNavigation<ImagePage, ImagePageViewModel>();
            containerRegistry.RegisterForNavigation<LocationPage, LocationPageViewModel>();
        }
    }
}
