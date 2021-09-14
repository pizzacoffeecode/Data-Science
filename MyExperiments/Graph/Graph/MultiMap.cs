using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class MultiMap<TKey, TValue, T>
    {
        //public TKey Key{get; set;}
        //public TValue Value {get; set;}
        //public T t { get; set; }
        public SortedDictionary<TKey, List<TValue>> Store {get; set;}
        public TKey Key {get; set;}
        public TValue Value {get; set;}
        public MultiMap()
        {
            this.Store = new SortedDictionary<TKey, List<TValue>>();
        }
        public void Add(TKey data1, TValue data2)
        {
            List<TValue> pullList;
            if (Store.Count == 0 || !Store.TryGetValue(data1, out pullList))
            {
                List<TValue> pushList = new List<TValue> { data2 };
                Store.Add(data1, pushList);
            }
            else if (!Store.TryGetValue(data1, out pullList))
            {
                pullList = new List<TValue>();
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
