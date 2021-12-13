﻿using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listem = new List<string>();
            listem.Add("Taha");
            listem.Add("Taha");
            listem.Add("Taha");
            Console.WriteLine(listem.Count);

            MyList<string> listem1 = new MyList<string>();
            listem1.Add("tk");
            listem1.Add("tk");
            listem1.Add("tk");
            listem1.Add("tk");
            Console.WriteLine(listem1.Count);

        }
    }
    class MyList<T>     //generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
        get  { return _array.Length;}
        
        }

}

}
