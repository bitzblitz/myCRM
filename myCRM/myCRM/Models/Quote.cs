using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM.Models
	{
	[ImplementPropertyChanged]
	public class Quote
		{
		public string CustomerName { get; set; }
		public decimal QuoteAmount { get; set; }
		}
	}
