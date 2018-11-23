using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace SoftEng
{
    public static class Wishlist
    {
        public static List<Search> wishList = new List<Search>();

        public static void addToWishlist(ListBox listView, RootObject items)
        {
            wishList.Add(items.Search[listView.SelectedIndex]);
        }
        public static void removeFromWishlist(ListBox listView, List<Search> items)
        {
            wishList.Remove(items[listView.SelectedIndex]);
        }
        public static void saveWishlist()
        {
            File.WriteAllText(Environment.CurrentDirectory + @"\wishlist.json", JsonConvert.SerializeObject(wishList));
        }
        public static void loadWishlist()
        {
            string contents = File.ReadAllText(Environment.CurrentDirectory + @"\wishlist.json");
            wishList = JsonConvert.DeserializeObject<List<Search>>(contents);
        }
		public static void displayToUI(ListBox listView2)
		{
			listView2.Items.Clear();
			foreach (var item in wishList)
			{
				listView2.Items.Add(item.ToString());
			}
		}
    }
}
