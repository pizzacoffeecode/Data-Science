using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class MultiMap<T>
    {
        //public TKey Key{get; set;}
        //public TValue Value {get; set;}
        //public T t { get; set; }
        public SortedDictionary<T, List<T>> Store {get; set;}
        public MultiMap()
        {
            this.Store = new SortedDictionary<T, List<T>>();
        }
        public void Add(T data1, T data2)
        {
            List<T> pullList;
            if (Store.Count == 0 || !Store.TryGetValue(data1, out pullList))
            {
                List<T> pushList = new List<T> { data2 };
                Store.Add(data1, pushList);
            }
            else if (!Store.TryGetValue(data1, out pullList))
            {
                pullList = new List<T>();
                Store.Add(data1, pullList);
            }
            else
            {
                pullList.Add(data2);
                Console.WriteLine($"Added {data2} to {data1}");
            }
        }
    }
}
