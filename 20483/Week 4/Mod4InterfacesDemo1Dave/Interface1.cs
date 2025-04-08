using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4InterfacesDemo1Dave
{
    internal interface IgenericMath<T>
    {
        T Add(T x, T y);
        T Multiply(T x, T y);
    }

    class Math<T> : IgenericMath<T>
    {
        public T Add(T x, T y)
        {
            throw new NotImplementedException();
        }

        public T Multiply(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}
