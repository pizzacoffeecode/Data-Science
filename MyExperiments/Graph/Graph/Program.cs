﻿using System;
using System.Collections.Generic;
using System.Collections;
using Graph;

namespace GraphStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(EdgeDirection.UNDIRECTED);

            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);

            PrintNodes(graph.Nodes);

            graph.AddEdge(1, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 5);
            graph.AddEdge(4, 5);
            graph.AddEdge(4, 3);

            //PrintGraph(graph.Nodes);
            //PrintEdges(graph.Edges);


            PrintEdges2(graph.Multi);

            Console.ReadKey();

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
            }

            //void PrintEdges(ArrayList edges)
            //{
            //    string result = string.Join("", edges.ToArray());
            //    Console.WriteLine($"Edge List = {result}");
            //}


            void PrintEdges2(MultiMap<int> multiMap)
            {
                foreach (KeyValuePair<int, List<int>> pair in multiMap.Store)
                {
                    string result = string.Join("", pair.Value);
                    Console.WriteLine($"{pair.Key} : {result}");

                }
            }
        }

    }
}
