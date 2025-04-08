using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Structdemo
{
    // value type
    public struct PostalAddress
    {
        //initialization
        public PostalAddress(int housenumber,string streetname, string city,string state,int zipcode)
        {
            HouseNumber = housenumber;
            StreetName = streetname;
            City = city;
            
            this.state = state;
            this.zipCode = zipcode;
        }
        public PostalAddress(int housenumber)
        {
            HouseNumber=housenumber;
            StreetName=string.Empty;
            City = string.Empty;
            this.zipCode = 0;
            this.state=string.Empty;
        }

        public int HouseNumber {  get; set; } // 2 way
        public string StreetName {  get; set; }
        public string City { get; set; }

        private int zipCode;
        public int ZipCode
        {
            get { return zipCode; }
            set {
                //logic to check if there 5 digits only
                zipCode = value; 
            }
        }

        //public int ZipCode {  get; set; }
       
        private string state; // private variable / field
       
        // 1 way property
        public string State
        {
            get {
                if (ZipCode == 111)
                    state = "NY";
                return state;
            
            }
        }

    }
}
