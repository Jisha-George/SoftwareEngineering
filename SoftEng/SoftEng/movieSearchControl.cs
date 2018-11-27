using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SoftEng
{
	public partial class movieSearchControl : UserControl
	{
		RootObject searchResults = new RootObject();		
		public movieSearchControl()
		{
			InitializeComponent();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			// https://api.themoviedb.org/3/search/movie?api_key=f1f657aa41450d44b2da1700714b44c9&query=harry
			api name = new api("3db990c4&", "http://www.omdbapi.com/?apikey=");
			string json = name.queryMovie("s=" + searchBox.Text);
			searchResults = JsonConvert.DeserializeObject<RootObject>(json);
			searchResults.movieListUI(listView);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Wishlist.addToWishlist(listView,searchResults);
		}

		private void button2_Click(object sender, EventArgs e)
		{
		
			api name = new api("f1f657aa41450d44b2da1700714b44c9", "https://api.themoviedb.org/3/search/movie?api_key=");
			string json = name.queryMovie("&query=" + searchBox.Text);
			searchResults = JsonConvert.DeserializeObject<RootObject>(json);
			searchResults.movieListUI(listView);

		}
	}
}
