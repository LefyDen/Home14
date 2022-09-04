using System;
using System.Collections.Generic;
using System.Linq;

namespace Home14
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(23);
            stack.Push(11);
            stack.Push(87);
            stack.Push(32);
            Console.WriteLine("Last one that was remuved" + stack.Pop());
            Console.WriteLine("Last one that was remuved" + stack.Peek());
            Console.WriteLine();
            Console.WriteLine(stack.Count()); 
            int[] toArray = new int[4];
            Console.WriteLine(  "Array :" );
            stack.CopyTo(ref toArray);
            foreach (var item in toArray)
            {
                Console.WriteLine(item);
            }
            stack.Clear();
            Console.WriteLine("Array was cleaned");
        }
    }
    class Stack<T>
    {
        List<T> list = new List<T>();
        public int countOfList;
        public int Count()
        {
            countOfList = list.Count;
            return countOfList;
        }

        public void Push(T fir)
        {
            list.Insert(0, fir);
        }

        public T Pop()
        {
            T last = list.Last();
            list.RemoveAt(list.Count - 1);
            return last;
        }
        public T Peek()
        {
            return list.Last();
        }
        public void Clear()
        {
            list.Clear();
        }
        public void CopyTo(ref T[] arr)
        {
            arr = list.ToArray();
        }
    }
}
