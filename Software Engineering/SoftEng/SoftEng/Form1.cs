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
		public Form1()
		{
			InitializeComponent();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			api name = new api("3db990c4&", "http://www.omdbapi.com/?apikey=");
			string json = name.queryMovie("s=" + searchBox.Text);
			var searchResults = JsonConvert.DeserializeObject<RootObject>(json);
			foreach(var item in searchResults.Search)
			{
				listView.Items.Add(item.ToString());
			}
		}
	}
}
