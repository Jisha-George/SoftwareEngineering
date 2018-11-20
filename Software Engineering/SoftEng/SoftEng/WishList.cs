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
    class Wishlist
    {
        private List<Search> wishList = new List<Search>();
        public Wishlist()
        {}

        public void addToWishlist(ListBox listView, RootObject items)
        {
            wishList.Add(items.Search[listView.SelectedIndex]);
        }
        public void removeFromWishlist(ListBox listView, RootObject items)
        {
            wishList.Remove(items.Search[listView.SelectedIndex]);
        }
        public void saveWishlist()
        {
            File.WriteAllText(Environment.CurrentDirectory + @"\wishlist.json", JsonConvert.SerializeObject(wishList));
        }
        public void loadWishlist()
        {
            string contents = File.ReadAllText(Environment.CurrentDirectory + @"\wishlist.json");
            wishList = JsonConvert.DeserializeObject<List<Search>>(contents);
        }
    }
}
