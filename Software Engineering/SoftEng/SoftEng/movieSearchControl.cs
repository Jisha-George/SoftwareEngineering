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
		Wishlist wishlist = new Wishlist();
		public movieSearchControl()
		{
			InitializeComponent();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			api name = new api("3db990c4&", "http://www.omdbapi.com/?apikey=");
			string json = name.queryMovie("s=" + searchBox.Text);
			searchResults = JsonConvert.DeserializeObject<RootObject>(json);
			searchResults.movieListUI(listView);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			wishlist.addToWishlist(listView,searchResults);
		}
	}
}
