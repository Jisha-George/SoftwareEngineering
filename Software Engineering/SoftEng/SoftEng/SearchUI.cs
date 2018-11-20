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
    public partial class SearchUI : Form1
    {
        RootObject searchResults;
        public SearchUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            api name = new api("3db990c4&", "http://www.omdbapi.com/?apikey=");
            string json = name.queryMovie("s=" + searchUI1.searchBox.Text);
            this.searchResults = JsonConvert.DeserializeObject<RootObject>(json);
            searchResults.movieListUI(searchUI1.listView);
        }
    }
}
