using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4InterfacesDemo1Dave
{
    //ABSTRACT CLASS
    internal abstract class AbstractClass //BASE of hierarchy, must be inherited--also means all methods must be public(?)
    {
        public void NormalMethod() //can have normal void methods
        {

        }
        public virtual void VirtualMethod() //can have virtual void methods
        {
            //logic
        }

        public abstract void AbstractMethod();

    }
    internal class DerivedClass : AbstractClass //make both classes internal, or both classes public
    {
        public override void AbstractMethod()
        {
            throw new NotImplementedException();
        }
        public override void VirtualMethod()
        {
            base.VirtualMethod();
        }
    }
    class B
    {

    }
    // Multiple inheritances not allowed (cannot do class A : DerivedClass, B) for example
    class A : DerivedClass
    {

    }
}
