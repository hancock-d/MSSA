using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3IndexerDemoDave
{
    internal class FoodMenu
    {
        //internal collection is private collection
        //using list so don't have to specify size
        private List<string> fooditems; //names of the foods will be put in there

        //Write a constructor
        //passing string as type, name foods
        public FoodMenu(List<string> foods)
        {
            //using this. ensures you access private fields
            this.fooditems = foods; //foods getting attached/added to food items
        }

        //Getting count of fooditems
        public int Count { get { return fooditems.Count; } } //3 items
        public string this[int index] //0, 1, 2 -- this index here is being sent to 29
        {
            get //think of get block as output function
            {
                if (index < this.Count)
                {
                    return this.fooditems[index];
                }
                return string.Empty;

            }
            set //job of set is not to return anything, just set the value in, think of it as input function
            {
                if (!this.fooditems.Contains(value)) //if food items does not contain _value_  Is value just a new variable?
                {
                    this.fooditems.Add(value); // add _value_ what is value? it's type string, decided by line 25
                    //this.fooditems[index] = value;
                }
            }
        }
    }
}
