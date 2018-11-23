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
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            movieSearchControl1.BringToFront();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            wishListUI1.showUI();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            movieSearchControl1.BringToFront();
        }
	}
}
