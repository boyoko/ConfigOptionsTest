using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamingTools.Configuration
{
	public class StorageSettings
	{
		public ConnectionStrings ConnectionStrings { get; set; }
	}

	public class ConnectionStrings
	{
		public TableStorageConnectionStrings TableStorage { get; set; }

		public EventHubConnectionStrings EventHubs { get; set; }

		public ServiceBusConnectionStrings ServiceBus { get; set; }
	}

	public class TableStorageConnectionStrings
	{
		public string LogEntriesByAccount { get; set; }
	}

	public class EventHubConnectionStrings
	{
		public string EventHubName { get; set; }

		public string IngestionQueue { get; set; }

		public string AccessKeyName { get; set; }

		public string AccessKeyToken { get; set; }

		public string ServiceNameSpace { get; set; }
	}

	public class ServiceBusConnectionStrings
	{
		public string GlobalQueue { get; set; }
	}
}
