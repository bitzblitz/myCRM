using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM.PageModels
	{
	//[ImplementPropertyChanged]
	public class MenuPageModel:FreshMvvm.FreshBasePageModel
		{
		public List<string> MenuItems { get; set; }
		public MenuPageModel()
			{

			}

		public override void Init(object initData)
			{
			base.Init(initData);
			MenuItems = new List<string> { "Quotes", "Contacts" };
			}

		public string SelectedMenuItem
			{
			get
				{
				return null;
				}
			set
				{
				switch(value)
					{
				case "Contacts":
					CoreMethods.PushPageModel<ContactListPageModel>();
					break;
				case "Quotes":
					CoreMethods.PushPageModel<QuoteListPageModel>();
					break;
					}
				RaisePropertyChanged();
				}
			}
		}
	}
