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
        Wishlist wishlist = new Wishlist();
        public Form1()
		{
			InitializeComponent();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            searchUI1.BringToFront();
            
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            searchUI1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            wishListUI1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            wishlist.addToWishlist(searchUI1.listView, this.searchResults);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wishlist.saveWishlist();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wishlist.loadWishlist();
        }
    }
}
