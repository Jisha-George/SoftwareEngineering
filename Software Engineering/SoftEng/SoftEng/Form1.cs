using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace SoftEng
{
	public partial class Form1 : Form
	{
        RootObject searchResults;
		public Form1()
		{
			InitializeComponent();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			api name = new api("3db990c4&", "http://www.omdbapi.com/?apikey=");
			string json = name.queryMovie("s=" + searchBox.Text);
			this.searchResults = JsonConvert.DeserializeObject<RootObject>(json);
            searchResults.movieListUI(listView);
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wishlist wishlist = new Wishlist();
            wishlist.addToWishlist(listView,this.searchResults);
        }
    }
}
