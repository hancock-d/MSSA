using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12Reflectiondemo
{
    [Serializable] //attribute
    [Obsolete("This class will be not available in future release")] //attribute

    internal class Class1
    {
        [NonSerialized] //attribute
        
        public string Name;
    }

    [AttributeUsage(AttributeTargets.All)] //attribute
    public class DeveloperInfoAttribute : Attribute
    {
        private string name;
        private string email;
        public string Name
        {
            get { return name; }
        }
        public string Email
        { get { return email; } }
        public DeveloperInfoAttribute(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
