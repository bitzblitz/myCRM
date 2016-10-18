using Acr.UserDialogs;
using myCRM.Models;
using myCRM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM.PageModels
	{
	public class QuoteListPageModel:FreshMvvm.FreshBasePageModel
		{
		public List<Quote> QuoteList { get; set; }
		private IUserDialogs _userDialogs;
		private IDataService _dataService;
		public QuoteListPageModel(IDataService DataService, IUserDialogs UserDialogs)
			{
			_userDialogs = UserDialogs;
			_dataService = DataService;
			}
		public Quote SelectedQuote
			{
			get
				{
				return null;
				}
			set
				{
				CoreMethods.PushPageModel<QuotePageModel>(value);
				RaisePropertyChanged();
				}
			}
		public override async void Init(object initData)
			{
			base.Init(initData);
			_userDialogs.ShowLoading();
			try
				{
				QuoteList = await _dataService.GetQuotes();
				}
			catch(Exception Ex)
				{
				_userDialogs.ShowError($"Error getting data: {Ex.Message}", 3000);
				}
			finally
				{
				_userDialogs.HideLoading();
				}
			}
		}
	}
