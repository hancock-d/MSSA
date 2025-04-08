﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Mod12Reflectiondemo
{
    internal class Program
    {
        // Reflection: it is a technique to read/ inspect/ manipulate  the metadata from other assemblies during 
        //runtime
        static void Main(string[] args)
        {

            //Mathdll.Class1 obj = new Mathdll.Class1(); //create a new object from the MAthdll library you created/added
            //obj.Add(); //now able to use the library on the new object 
            // Design time binding :we added the reference at design time
            //Mathcls mathcls = new Mathcls();
            //mathcls.Add()
            // we are loading mathdll dynamically at runtime (using reflection)
            string assemblypath = @"C:\MSSA\PCAD16\20483\Week 12\Mathcls\bin\Debug\Mathcls.dll"; //your assembly path for the dll
            var assembly = Assembly.LoadFrom(assemblypath);

            Console.WriteLine($"Assembly name: {assembly.FullName}, assembly version:{assembly.ImageRuntimeVersion}");
            // classes, structures, interfaces, delegates
            var types = assembly.GetTypes();
            // read through all the types
            foreach (var type in types)
            {

                Console.WriteLine(type.FullName);
                var methods = type.GetMethods();
                foreach (var method in methods)
                {



                    Console.WriteLine(method.Name);
                    if (method.Name == "Equals")
                    {
                        break;
                    }
                    if (!method.IsStatic)
                    {
                        // Mathcls obj=new Matchcls();

                        var obj = Activator.CreateInstance(type);
                        var result = type.InvokeMember(method.Name, BindingFlags.InvokeMethod, null, obj, new object[] { 30, 20 });
                        Console.WriteLine($"Result of {method.Name} is  {result}");
                    }

                }

            }

            Console.WriteLine("Reading custom attributes:");
            var type_class = typeof(Demo);// class on which attrib is applied

            var attributes = type_class.GetCustomAttributes(true);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
                var val = (DeveloperInfoAttribute)attribute;
                Console.WriteLine($"attribute values: {val.Name} and {val.Email}");
            }

            Console.ReadKey();
        }
    }
}
