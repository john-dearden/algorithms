using NUnit.Framework;

namespace Algorithms.Dijkstra.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            // Create weighted edges for the graph
            Edge[] edges = {
                new Edge("A","B",8),
                new Edge("A", "C", 10),
                new Edge("B", "D", 11),
                new Edge("B", "E", 11),
                new Edge("C", "D", 7),
                new Edge("C", "E", 9),
                new Edge("D", "F", 9),
                new Edge("E", "F", 9),
            };

            Graph graph = Graph.Create(edges);

            var route = graph.Route("A", "F");

            graph.Print(new ConsolePrinter());

            Assert.Equals("ACEF", route);
        }
    }
}