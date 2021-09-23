using Graph;
using System.Collections;
using System.Collections.Generic;

namespace GraphStructure
{

    public enum EdgeDirection
    {
        DIRECTED, UNDIRECTED
    }
    public class Graph
    {
        public SortedDictionary<int, Node> Nodes { get; set; }
        public EdgeDirection EdgeDirection { get; set; }

        public ArrayList Edges { get; set; }

        public MultiMap<int> Multi { get; set; }


        // Constructor
        public Graph(EdgeDirection edgeDirection)
        {
            Nodes = new SortedDictionary<int, Node>();

            Edges = new ArrayList();

            Multi = new MultiMap<int>();

            EdgeDirection = edgeDirection;
        }

        // Methods
        public Node AddVertex(int value)
        {
            Node node = new Node(value);
            Nodes.Add(value, node);
            return node;
        }

        public void AddEdge(int source, int destination)
        {
            //// VERSION : ARRAYLIST ON EACH NODE
            //if (Edges.Count == 0)
            //{
            //    for (int i = 0; i < Nodes.Count - 1; i++)
            //    {
            //        Edges.Add(0);
            //    }
            //}

            //Node sourceNode;
            //if (Nodes.TryGetValue(source, out sourceNode))
            //{
            //    sourceNode.AddAdjacent(destination);
            //}

            //Edges.Insert(source, destination);

            //if (this.EdgeDirection == EdgeDirection.UNDIRECTED)
            //{
            //    Node destinationNode;
            //    if (Nodes.TryGetValue(destination, out destinationNode))
            //    {
            //        Console.WriteLine("adding undirected");
            //        destinationNode.AddAdjacent(source);
            //    }
            //    Edges.Insert(destination, source);
            //}



            //// VERSION : One MultiMap on Graph
            Multi.Add(source, destination);
        }

        // HELPER METHODS
    }
}





// FOR DELETION - Sorted Dict with List...turned into own class MultiMap
//List<int> list;
//if (Edges2.Count == 0 || !Edges2.TryGetValue(source, out list))
//{
//    List<int> upList = new List<int> { destination };
//    Edges2.Add(source, upList);
//}            
//else if (!Edges2.TryGetValue(source, out list))
//{
//    list = new List<int>();
//    Edges2.Add(source, list);
//}
//else
//{
//    list.Add(destination);
//    Console.WriteLine($"Added {destination} to {source}");
//}
//if (this.EdgeDirection == EdgeDirection.UNDIRECTED)
//{
//    List<int> list2;
//    if (Edges2.Count == 0 || !Edges2.TryGetValue(destination, out list2))
//    {
//        List<int> upList = new List<int> { source };
//        Edges2.Add(destination, upList);
//    }
//    else if (!Edges2.TryGetValue(destination, out list2))
//    {
//        list2 = new List<int>();
//        Edges2.Add(destination, list2);
//    }
//    else
//    {
//        list2.Add(source);
//        Console.WriteLine($"Added {source} to {destination}");
//    }
//}