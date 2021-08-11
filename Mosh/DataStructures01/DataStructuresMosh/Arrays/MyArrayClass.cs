using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace DataStructuresMosh.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray numbers = new MyArray(3);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);
            numbers.RemoveAt(2);
            numbers.IndexOf(11);
            numbers.Print();
        }
    }
    public class MyArray        // Think this is Mosh's version
    {
        private int[] items;
        private int count;
        public MyArray(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            // If the array is full need to resize
            // Add the new item at the end

            if (items.Length == count)      // VERY INTERESTING | true case of just using an IF and not and ELSE...we always want the code below if to run
            {
                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];
                // Copy all the existing items
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                // Set "items" to this new array
                items = newItems;
                Console.WriteLine("Expanded Array to {0}", items.Length);
            }

            items[count++] = item;      // IMPORTANT :  item first equals the value of count ' then after' count is incremented, not before
        }

        public void RemoveAt(int index)
        {
            string item = items[index].ToString();
            // Validate the index
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Yo Easy Tiger - IndexOutOfRangeException");
            }
            // Shift the items to the left to fill the hole
            else
            {
                for (int i = index; i < count; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;    // count is decreased not the items.length since we just want to know th eamount of items in the array for accuracy, we can have some space left over
                Console.WriteLine("Item {0} removed from index {1} | There are {2} items left in array | Array size is now {3}", item, index, count, items.Length);
            }
        }

        // runtime complextit is O(n), if it input was 1 million it would have to go through the whole index
        public int IndexOf(int item)    // Bad naming, it's not searching for an index, its searching for the value at that index
        {
            for (int i = 0; i < count; i++)
            {
                if (item == (int)items[i])
                {
                    Console.WriteLine("Your item {0} found at index {1}", item, i);
                    return i;
                }
            }
            Console.WriteLine("Your item {0} was not found", item);
            return -1;
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
            Console.WriteLine("---");
        }
    }
}
