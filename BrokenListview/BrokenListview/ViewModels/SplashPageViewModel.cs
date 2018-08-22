using System;
using System.Collections.Generic;
using System.Text;
using BrokenListview.Views;
using Prism.Commands;
using Prism.Navigation;

namespace BrokenListview.ViewModels
{
    class SplashPageViewModel
    {
		public DelegateCommand NotWorkCommand { get; }
		public DelegateCommand WorkCommand { get; }
		private INavigationService navigationService;
		public SplashPageViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
			NotWorkCommand = new DelegateCommand(async () => await this.navigationService.NavigateAsync(nameof(NotWorkingPage)));
			WorkCommand = new DelegateCommand(async () => await this.navigationService.NavigateAsync(nameof(WorkingPage)));
		}
	}
}
