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
	public class ContactListPageModel:FreshMvvm.FreshBasePageModel
		{
		public List<Contact> ContactList { get; set; }
		private IDataService _dataService;
		private IUserDialogs _userDialogs;
		public Contact SelectedContact
			{
			get
				{
				return null;
				}
			set
				{
				CoreMethods.PushPageModel<ContactPageModel>(value);
				RaisePropertyChanged();
				}
			}
		public ContactListPageModel(IDataService DataService, IUserDialogs UserDialogs)
			{
			_dataService = DataService;
			_userDialogs = UserDialogs;
			}

		public override async void Init(object initData)
			{
			base.Init(initData);
			_userDialogs.ShowLoading();
			try
				{
				ContactList = await _dataService.GetContacts();
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
