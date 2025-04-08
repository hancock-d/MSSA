using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Demo1
{
    //Immutable object is the one getting its state (data) when we create the object
    // It (the state (data) CANNOT be moditied later
    // by making readonly properties
    internal class Document
    {
        private string name;
        private string content;
        public Document(string name, string content) //Constructor--initializing data 
        {
            this.name = name;
            this.content = content;
        }
        //Readonly property, allows assignment only while object is getting created
        //Immutable
        public string Name { get { return this.name; } } // read only property
        public string Content { get { return this.content; } } //public property that provides access to it, but it is read only
    }
}
