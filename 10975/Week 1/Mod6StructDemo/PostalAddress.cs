using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6StructDemo
{
    //value type (struct). 
  //access specifier - ??? - ????
    public struct PostalAddress //change internal to public so it can be accessed outside this namespace (like into client code), specifies access level. Change class to struct
    {
        //initializations
        public PostalAddress(int housenumber, string streetname, string city, string state, int zipcode) //passing these values to the data you have passed to the variable of the constructor
        {
            HouseNumber = housenumber;
            StreetName = streetname;
            City = city;

            this.state = state; //using this.X cause it's an internal member. allows you to point to the private members of the class or structure. 
            this.zipCode = zipcode; 
        }
        public PostalAddress(int housenumber)
        {
            HouseNumber = housenumber;
            StreetName = string.Empty;
            City = string.Empty; //assigning value as empty
            this.zipCode = 0; //assigning value as empty
            this.state = string.Empty;
        }
        public int HouseNumber { get; set; } //written a property names HouseNumber, property type int, available to public. get set --get the data, write the data. get allows only to get/read the data
        public string StreetName { get; set; } //2-way property (get; set;), 2-way binding
        public string City { get; set; }

        private int zipCode;
        public int ZipCode
        {
            get { return zipCode; }
            set {
                //logic to checkk if there are 5 digits only
                zipCode = value;
            }
        }
        //public int ZipCode { get; set; }   //this is all just writing properties, allows you to attach/bind data to front end (like in mobile apps)
        private string state; //private field of a private property/variable in this structure, not accessible outside this structure.
        
        
        //1-way property, only getting (no set block)
        public string State //State is a property
        {
            get { //read only
                if (ZipCode == 1111)
                    state = "NY";
                return state;

            }
        }
    }
}
