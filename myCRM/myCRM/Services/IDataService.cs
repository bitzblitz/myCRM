using myCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM.Services
	{
	public interface IDataService
		{
		Task<List<Contact>> GetContacts();
		Task<List<Quote>> GetQuotes();
		}
	}
