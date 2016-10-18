using Acr.UserDialogs;
using myCRM.PageModels;
using myCRM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace myCRM
	{
	public partial class App:Application
		{
		public App()
			{
			//InitializeComponent();
			SetupIOC();
			//SetupSingleNav();
			//SetupMasterDetail();
			SetupTabbedNav();
			}

		private void SetupIOC()
			{
			FreshMvvm.FreshIOC.Container.Register<IDataService, DataService>();
			FreshMvvm.FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
			}

		private void SetupSingleNav()
			{
			var page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<MenuPageModel>(null);  // does dependency injection
			var singleNav = new FreshMvvm.FreshNavigationContainer(page);
			MainPage = singleNav;
			}

		private void SetupMasterDetail()
			{
			var masterDetail = new FreshMvvm.FreshMasterDetailNavigationContainer();
			masterDetail.AddPage<ContactListPageModel>("Contacts");
			masterDetail.AddPage<QuoteListPageModel>("Quotes");
			masterDetail.Init("Menu");
			MainPage = masterDetail;
			}

		private void SetupTabbedNav()
			{
			var tabbedNav = new FreshMvvm.FreshTabbedNavigationContainer();
			tabbedNav.AddTab<ContactListPageModel>("Contacts", null);
			tabbedNav.AddTab<QuoteListPageModel>("Quotes", null);
			MainPage = tabbedNav;
			}

		private void SetupMasterDetailNav()
			{

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
