using Microsoft.Extensions.Options;
using NamingTools.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamingTools.Storage
{
	public interface IMyStore
	{
		Task Setup();
	}
	public class MyStore : IMyStore
	{
		private readonly string _connectionString;

		public MyStore(IOptions<StorageSettings> storageOptions)
		{
			_connectionString = storageOptions.Value.ConnectionStrings.TableStorage.LogEntriesByAccount;
		}

		public async Task Setup()
		{
			await Task.Run(() =>
			{
				// Dummy
			});
		}
	}
}
