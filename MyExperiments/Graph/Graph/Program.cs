using System;
using System.Collections.Generic;

namespace GraphStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node node = new Node(0);
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Console.WriteLine(node);
            //Console.WriteLine(node.Value);

            Graph graph = new Graph(EdgeDirection.UNDIRECTED);

            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);

            PrintNodes(graph.Nodes);



            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);

            PrintGraph(graph.Nodes);


            // Program Helper Methods
            void PrintNodes(SortedDictionary<int, Node> nodes)
            {
                var list = new List<int>(nodes.Keys);   // Copy keys to list
                Node node;
                foreach (var key in list)
                {
                    nodes.TryGetValue(key, out node);
                    Console.WriteLine(node.Value);
                }
            }

            void PrintGraph(SortedDictionary<int, Node> nodes)
            {
                foreach (KeyValuePair<int,Node> pair in nodes)
                {
                    string result = string.Join("", pair.Value.Adjacents);
                    Console.WriteLine($"{pair.Key} : {result}");

                }
                //var list = new List<int>(nodes.Keys);   // Copy keys to list
                //Node node;
                //foreach (var key in list)
                //{
                //    nodes.TryGetValue(key, out node);
                //    node.PrintAdjacents();
                //}
            }

        }

    }
}
