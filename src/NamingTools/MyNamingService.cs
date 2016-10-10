using Microsoft.Extensions.Options;
using NamingTools.Configuration;
using NamingTools.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamingTools
{
	public interface INamingService
	{
		string GetAppName();
		Task Setup();
	}

	public class MyNamingService : INamingService
	{
		private readonly IMyStore _store;
		private string _displayName;

		public MyNamingService(IMyStore store)
		{
			_store = store;
		}

		public string GetAppName()
		{
			return _displayName;
		}

		public async Task Setup()
		{
			await _store.Setup();

			_displayName = $"The best app";
		}
	}
}
