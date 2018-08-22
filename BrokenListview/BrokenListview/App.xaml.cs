using System;
using BrokenListview.ViewModels;
using BrokenListview.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BrokenListview
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer) : base(initializer) { }

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<NotWorkingPage, PageViewModel>();
			containerRegistry.RegisterForNavigation<WorkingPage, PageViewModel>();
			containerRegistry.RegisterForNavigation<SplashPage>();
		}

		protected override void OnInitialized()
		{
			InitializeComponent();
			NavigationService.NavigateAsync(nameof(SplashPage));
		}
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
