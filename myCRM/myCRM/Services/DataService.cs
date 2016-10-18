using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myCRM.Models;

namespace myCRM.Services
	{
	public class DataService:IDataService
		{
		private List<Contact> _contacts = new List<Contact> { new Contact { Name = "John", Number = "23" }, new Contact { Name = "Erika", Number = "51" } };
		private List<Quote> _quotes = new List<Quote> { new Quote { CustomerName = "XAM Consulting Pty. Limited", QuoteAmount = 423.05M }, new Quote { CustomerName = "CogniDyne Research Corp.", QuoteAmount = 524.6M } };
		public async Task<List<Contact>> GetContacts()
			{
			await Task.Delay(TimeSpan.FromSeconds(3));	// simulate network delay.
			return _contacts;
			}

		public async Task<List<Quote>> GetQuotes()
			{
			await Task.Delay(TimeSpan.FromSeconds(3));	// simulate network delay.
			return _quotes;
			}

		public DataService()
			{

			}
		}
	}
