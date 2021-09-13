using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphStructure
{
    public class Node
    {
        public int Value { get; private set; }

        public List<int> Adjacents { get; set; }
    
        // Constructor
        public Node(int value)
        {
            Value = value;
            Adjacents = new List<int>();  // adjacency list
        }

        public void AddAdjacent(int node)
        {
            this.Adjacents.Insert(0, node);
        }

        public int RemoveAdjacent(int node)
        {
            foreach (var item in Adjacents)
            {
                if (node == item)
                {
                    return item;
                }
            }
            Console.WriteLine("Nothing found to remove");
            return -1;
        }

        public List<int> GetAdjacents()
        {
            return this.Adjacents;
        }

        public void PrintAdjacents()
        {
            string result = string.Join("", Adjacents);
            Console.WriteLine(result);
        }


        public int isAdjacent(Node node)
        {
            return this.Adjacents.IndexOf(node.Value);
        }
    }
}
