using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigOptionsTest.Options
{
	public class MyOptions
	{
		public NamingOptions NamingOptions { get; set; }
	}

	public class NamingOptions
	{
		public WebAppNamingOptions WebApp { get; set; }
	}

	public class WebAppNamingOptions
	{
		public string MyAppName { get; set; }
	}
}
