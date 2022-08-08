using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Model_Item
{
    internal class Item
    {

        public int number { get; set; }
        public DateTime dates { get; set; }
        public int inventory_number { get; set; }
        public string object_name { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public bool isAvailable { get; set; }
        private static List<Item> items = new List<Item>();
        public static  Item findOne(string name)
        {
            return items.Find(i => i.object_name == name);
        }

        public string save()
        {
            items.Add(this);
            return object_name;
        }
       
        public static List<Item> getAll()
        {
            return items;
        }
    }
}
