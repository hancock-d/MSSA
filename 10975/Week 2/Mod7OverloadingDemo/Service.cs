using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7OverloadingDemo
{
    internal class Service
    {
        public int ServiceId {  get; set; }
        public string ServiceName { get; set; }
        public bool IsRunning { get; set; } //indicate if service is running or not, will take true or false
        public Service()
        {
            ServiceId = 0; //initializing/getting defaulted to 0
            ServiceName = string.Empty; //don't want a service name, leave it empty
            IsRunning = false;
        }

        //overloaded constructor
        public Service(int serviceId) //just passing ServiceId
        {
            ServiceId = serviceId;
        }

        //method/function overloading
        public void StartService(int serviceId) //only starts this method if you have the Id
        {
            //logic to start
            IsRunning = true; 
        }
        public void StartService(string serviceName) //overloaded method, but have the name of serviceName
        {
            IsRunning = true; //
        }
        public void StartService(int serviceId, string serviceName) //overloaded, but have both name and Id
        {
            IsRunning = true;
        }
    }
}
