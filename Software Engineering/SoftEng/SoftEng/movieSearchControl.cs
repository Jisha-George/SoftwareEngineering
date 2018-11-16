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
		public movieSearchControl()
		{
			InitializeComponent();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			api name = new api("3db990c4&", "http://www.omdbapi.com/?apikey=");
			string json = name.queryMovie("s=" + searchBox.Text);
			var searchResults = JsonConvert.DeserializeObject<RootObject>(json);
            listView.Items.Clear();
			foreach (var item in searchResults.Search)
			{
				listView.Items.Add(item.ToString());
			}
		}
	}
}
