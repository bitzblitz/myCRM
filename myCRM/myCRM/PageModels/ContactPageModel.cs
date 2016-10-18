using myCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM.PageModels
	{
	public class ContactPageModel:FreshMvvm.FreshBasePageModel
		{
		public Contact Contact { get; set; }

		public ContactPageModel()
			{

			}

		public override void Init(object initData)
			{
			base.Init(initData);
			Contact = initData as Contact;
			}
		}
	}
