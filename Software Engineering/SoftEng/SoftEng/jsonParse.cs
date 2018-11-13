using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SoftEng
{
	class movie
	{
		public string Title { get; set; }
		public string Year { get; set; }
		public string imbdbID { get; set; }
		public string Type { get; set; }
		public string Poster { get; set; }


		public override string ToString()
		{
			return $"Title:{this.Title} Year:{this.Year} ID {this.Type}";
		}




	}

	class movieList
	{
		public List<movie> movie { get; set; }
		public string totalResults { get; set; }
		public string Response { get; set; }


		public movieList(string json)
		{
			var des = (movieList)Newtonsoft.Json.JsonConvert.DeserializeObject(json,typeof(movieList));
			Console.ReadLine();
		}
	}
}
