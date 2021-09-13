using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphStructure
{

    public enum EdgeDirection
    {
        DIRECTED, UNDIRECTED
    }
    public class Graph
    {
        public SortedDictionary<int, Node> Nodes { get; set; }
        public SortedDictionary<int, int[]> Edges { get; set; }
        public EdgeDirection EdgeDirection { get; set; }
 
        // Constructor
        public Graph(EdgeDirection edgeDirection)
        {
            Nodes = new SortedDictionary<int, Node>();

            this.EdgeDirection = edgeDirection;
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
            Node sourceNode;
            if (Nodes.TryGetValue(source, out sourceNode))
            {
                sourceNode.AddAdjacent(destination);
            }


            //if (this.EdgeDirection == EdgeDirection.UNDIRECTED)
            //{
            Node destinationNode;
            if (Nodes.TryGetValue(destination, out destinationNode))
            {
                Console.WriteLine("adding undirected");
                sourceNode.AddAdjacent(source);
            }
        }


        // HELPER METHODS


    }
}
