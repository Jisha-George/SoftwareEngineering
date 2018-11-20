using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace SoftEng
{
	public class Result
	{
		public int vote_count { get; set; }
		public int id { get; set; }
		public bool video { get; set; }
		public double vote_average { get; set; }
		public string title { get; set; }
		public double popularity { get; set; }
		public string poster_path { get; set; }
		public string original_language { get; set; }
		public string original_title { get; set; }
		public List<int> genre_ids { get; set; }
		public string backdrop_path { get; set; }
		public bool adult { get; set; }
		public string overview { get; set; }
		public string release_date { get; set; }

		public override string ToString()
		{
			return $"Title: {this.title} Year: ({this.release_date}) ID:{this.id} Type: {this.}";
		}
	}

	public class RootObjectResult
	{
		public int page { get; set; }
		public int total_results { get; set; }
		public int total_pages { get; set; }
		public List<Result> results { get; set; }

	public void movieListUI(ListBox listView)
		{
			foreach (var item in this.results)
			{
				listView.Items.Add(item.ToString());
			}
		}
	}
}
