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
	public partial class Client : Form
	{
		public Client()
		{
			InitializeComponent();
			SidePanel.Height = button1.Height;
			movieSearchControl1.BringToFront();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SidePanel.Height = button1.Height;
			movieSearchControl1.BringToFront();
		}
	}
}
