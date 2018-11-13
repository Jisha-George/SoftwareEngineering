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
			ListViewItem itm;
			string json = name.queryMovie("s="+searchBox.Text);
			itm = new ListViewItem(json);
			resultView.Items.Add(itm);
		}
	}
}
