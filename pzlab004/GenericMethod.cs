using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pzlab004
{
    public class GenericMethod
    {
        public static void Swap<T>(ref T firstValue, ref T secondValue) 
        { 
            var temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }
        public static void DescObject<T, Y>(ref T temp, ref Y temp2)
        {
            Console.WriteLine(temp.GetType().Name + " Stan: " + temp);
            Console.WriteLine(temp2.GetType().Name + " Stan: " + temp2);
            temp = default(T);
            temp2 = default(Y);

        }
        public static T CreateNewObject<T>() where T : new()
        {
            return new T();
        }
        public static T Compare<T>(T temp1, T temp2) where T : IComparable<T>
        {
            if (temp1.CompareTo(temp2) > 0)
                return temp2;

            return temp2;
        }
        public static List<T> SortParameters<T>(params T[] list) where T : IComparer<T>
        {
            Array.Sort(list);
            return list.ToList();
        }
        public static Dictionary<T, Y> CreateDictionery<T, Y>(T key, Y value) where T : struct where Y : class
        {
            Dictionary<T, Y> temp = new Dictionary<T, Y>
            {
                { key, value }
            };
            return temp;
        }
        public static void ShowDictionery<T,Y>(List<Dictionary<T,Y>> list)
        {
            list.ForEach(x => Console.WriteLine("Klucz: " + x.Keys + " || Wartość: " + x.Values));
        }
        public static IEnumerable<T> CreateQueueOrStack<T>(params T[] list)
        {
            if (list.Count() >= 3)
            {
                var temp = new Stack<T>();
                foreach (var item in list)
                {
                    temp.Push(item);
                }
                return temp;
            }
            var temp2 = new Queue<T>();
            foreach (var item in list)
            {
                temp2.Enqueue(item);
            }
            return temp2;
        }
    }
}
