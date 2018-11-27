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
	public class Search
	{


		public string Title { get; set; }
		public string Year { get; set; }
		public string imdbID { get; set; }
		public string Type { get; set; }
		public string Poster { get; set; }

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
			if (this.Title != null)
			{
				return $"Title: {this.Title} Year: ({this.Year}) ID:{this.imdbID} Type: {this.Type}";
			}

			else if (this.title != null)
			{

				return $"Title: {this.title} Year: ({this.release_date}) ID:{this.id} Type: {this.poster_path}";
			}

			else { return $"Error"; }
			



		}
	}

	public class RootObject
	{
		public List<Search> Search { get; set; }
		public string totalResults { get; set; }
		public string Response { get; set; }

		public int page { get; set; }
		public int total_results { get; set; }
		public int total_pages { get; set; }

		public List<Search> results { get; set; }

		public void movieListUI(ListBox listView)
        {

			if (Search != null)
			{
				listView.Items.Clear();
				foreach (var item in Search)
				{
					listView.Items.Add(item.ToString());
				}

			}

			else if (results != null)
			{
				listView.Items.Clear();
				foreach (var item in results)
				{
					listView.Items.Add(item.ToString());
				}


			}
           



		}
	}
}
