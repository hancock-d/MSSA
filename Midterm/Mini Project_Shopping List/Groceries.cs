using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_Shopping_List
{
    class GroceryData
    {
        public static List<Grocery> Groceries = new List<Grocery>();

        public static Dictionary<StoreName, string> StoreNames = new Dictionary<StoreName, string>
        {
            { StoreName.StoreA, "Store A" }, // Default names
            { StoreName.StoreB, "Store B" }
        };

    }

    //enum Quantity
    //{
        
    //    _1 = 1,
    //    _2,
    //    _3,
    //    _4,
    //    _5,
    //    _6,
    //    _7,
    //    _8,
    //    _9,
    //    _10,
    //}

    enum StoreName
    {
        StoreA = 1,
        StoreB,
    }
    class Grocery
    {
        public string GroceryItem { get; set; }
        public int Quantity { get; set; }
        public StoreName StoreName { get; set; }

        public Grocery(string groceryitem, int quantity, StoreName storename)
        {
            this.GroceryItem = groceryitem;
            this.Quantity = quantity;
            this.StoreName = storename;
        }

    }

}

