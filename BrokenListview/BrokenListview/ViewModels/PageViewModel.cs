using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;
using BrokenListview.Models;

namespace BrokenListview.ViewModels
{
    class PageViewModel : BindableBase, INavigationAware
	{
		private ObservableCollection<ComplexType> someCollection = new ObservableCollection<ComplexType> {};
		public ObservableCollection<ComplexType> SomeCollection
		{
			get { return someCollection; }
			set { SetProperty(ref someCollection, value); }
		}
		private string testBind;
		public string TestBind
		{
			get { return testBind; }
			set { SetProperty(ref testBind, value); }
		}
		public PageViewModel()
		{
			TestBind = "This is to see if Binding works";
		}

		public void OnNavigatedFrom(INavigationParameters parameters)
		{
		}

		public async void OnNavigatedTo(INavigationParameters parameters)
		{
			await Task.Run(() =>
			{
				Task.Delay(100);
				SomeCollection.Add(new ComplexType{ Title ="title1", Note="note1"});
				SomeCollection.Add(new ComplexType{ Title ="title2", Note="note2"});
				SomeCollection.Add(new ComplexType{ Title ="title3", Note="note3"});
			});
		}

		public void OnNavigatingTo(INavigationParameters parameters)
		{
		}
	}
}
