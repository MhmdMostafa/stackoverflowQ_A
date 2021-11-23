using System;
using System.Collections.Generic;
namespace Q_69972021
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRow = 4;
            int maxColumn = 4;

            int maxHorizontalEdges = (maxRow - 1) * maxRow;
            int maxVerticalEdges = (maxColumn - 1) * maxColumn;

            List<Node> Nodes = new List<Node>();
            List<Edge> Hedges = new List<Edge>();
            List<Edge> Vedges = new List<Edge>();


            int times = 0;
            int pos = 0;

            for (int row =0; row< maxRow; row++)
            {
                for(int column = 0; column < maxColumn; column++)
                {
                    Node newNode = new Node();
                    newNode.X = row;
                    newNode.Y = column;
                    newNode.data = $"({row},{column})";
                    Nodes.Add(newNode);
                }
            }

            for (int row = 0; row < maxHorizontalEdges; row++)
            {
                Edge newEdge = new Edge();
                Hedges.Add(newEdge);
            }

            for (int column = 0; column < maxVerticalEdges; column++)
            {
                Edge newEdge = new Edge();
                Vedges.Add(newEdge);
            }

            for (int e=0; e< maxVerticalEdges; e++)
            {
                if (times == maxColumn - 1)
                {
                    pos++;
                    times = 0;
                }
                Vedges[e].naighbor_1 = Nodes[pos];
                Vedges[e].naighbor_2 = Nodes[++pos];
                times++;

            }

            pos = 0;
            times = 0;
            for (int e = 0; e < maxHorizontalEdges; e++)
            {
                
                Hedges[e].naighbor_1 = Nodes[pos];
                Hedges[e].naighbor_2 = Nodes[pos+maxRow];
                pos++;
                times++;

            }
            Console.WriteLine($"Nodes>>>");

            int count = 0;
            foreach (Node n in Nodes)
                Console.WriteLine($"Node_{++count} (X,Y) = ({n.X}, {n.Y})");
            Console.WriteLine($"\n\n\n\n");


            Console.WriteLine($"Vertical Edges>>>");
            count = 0;
            foreach (Edge e in Vedges)
                Console.WriteLine($"Edge_{++count}>> \tneighbor_1-{e.naighbor_1.data}\n\t\tneighbor_2-{e.naighbor_2.data}\n");
            Console.WriteLine($"\n\n\n\n");


            Console.WriteLine($"Horizontal Edges>>>");
            count = 0;
            foreach (Edge e in Hedges)
                Console.WriteLine($"Edge_{++count}>> \tneighbor_1-{e.naighbor_1.data}\n\t\tneighbor_2-{e.naighbor_2.data}\n");

        }


        
    }


    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string data { get; set; }
    }


    public class Edge
    {
        public Node naighbor_1 = new Node();
        public Node naighbor_2 = new Node();
    }
}
