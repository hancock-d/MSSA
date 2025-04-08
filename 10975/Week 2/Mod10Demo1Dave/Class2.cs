using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Demo1Dave
{
    //  UNMANAGED OBJECTS
    internal class UsingWord:IDisposable
    {
        private bool disposedValue;

        public UsingWord() //constructor to use unmanaged object
        {

        }
        //finalizaer
        // GC will put the object of this class in a seperate Queue: FReachable Q
        ~UsingWord() //destructor, non-deterministic
        {
            //logic to destruct the unmanaged object
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UsingWord()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this); //remove / do not put the object in the FReachable Q
        }
    }
}
