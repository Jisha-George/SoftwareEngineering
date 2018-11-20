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

		public override string ToString()
		{
			return $"Title: {this.Title} Year: ({this.Year}) ID:{this.imdbID} Type: {this.Type}";
		}
	}

	public class RootObject
	{
		public List<Search> Search { get; set; }
		public string totalResults { get; set; }
		public string Response { get; set; }

        public void movieListUI(ListBox listView)
        {
            listView.Items.Clear();
            foreach (var item in Search)
            {
                listView.Items.Add(item.ToString());
            }
        }
	}
}
