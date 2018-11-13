using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SoftEng
{
	class api
	{
		public string url;
		public string apiKey;
		public string call;
		public api(string key, string url)
		{
			this.apiKey = key;
			this.url = url;
			this.call = url + key;
		}

		public string queryMovie(string title)
		{
			string json = new WebClient().DownloadString(call + title);
			return json;
		}
	}
}
