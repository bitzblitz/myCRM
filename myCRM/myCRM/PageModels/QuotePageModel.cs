using myCRM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM.PageModels
	{
	public class QuotePageModel:FreshMvvm.FreshBasePageModel
		{
		public Quote Quote { get; set; }

		public QuotePageModel()
			{

			}

		public override void Init(object initData)
			{
			base.Init(initData);
			Quote = initData as Quote;
			}
		}
	}
