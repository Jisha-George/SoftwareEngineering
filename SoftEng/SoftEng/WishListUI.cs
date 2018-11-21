using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEng
{
    public partial class WishListUI : UserControl
    {
        public WishListUI()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wishlist.saveWishlist();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wishlist.loadWishlist();
            Wishlist.displayToUI(listBox1);
        }
    }
}
