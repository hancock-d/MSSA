﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4InterfacesDemo1Dave
{
    class CustomList<T> : IList<T> //write your own custom list of int type(?) T Type(?)
    {
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    internal interface IMath //Interface class starts with "I"
    {
        int Add(int x, int y); //no implementation, just signature of the method--What's int he ()
        int Subtract(int x, int y);


    }
    class MathCal : IMath, IDisposable
    {
        public int Add(int x, int y) //click lightbulb, down arrow, implement interfaces
        {
            return x + y;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
