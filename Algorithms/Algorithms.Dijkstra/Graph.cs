using System;
using System.Collections.Generic;

namespace Algorithms.Dijkstra
{
    public class Edge : IComparable<Edge>
    {
        public string FromVertex { get; private set; }
        public string ToVertex { get; private set; }

        /// <summary>
        /// Gets the weight of the <see cref="Edge"/>
        /// </summary>
        public int Weight { get; private set; }

        public Edge(string fromVertex, string toVertex, int weight)
        {
            this.FromVertex = fromVertex;
            this.ToVertex = toVertex;
            this.Weight = weight;
        }

        public string Target(string label)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Edge other)
        {
            if (this.Weight < other.Weight)
            {
                return -1;
            }
            else if (this.Weight > other.Weight)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{this.FromVertex:d}->{this.ToVertex:d} {this.Weight:f5}";
        }
    }

    public interface IGraphPrinter
    {

    }

    public class ConsolePrinter : IGraphPrinter
    {

    }

    public class Graph
    {
        private readonly Edge[] edges;

        public static Graph Create(Edge[] edges)
        {
            throw new NotImplementedException();
        }

        public string Route(string start, string end)
        {
            
            throw new NotImplementedException();
        }

        public void Print(IGraphPrinter graphPrinter)
        {
            throw new NotImplementedException();
        }
    }
}
