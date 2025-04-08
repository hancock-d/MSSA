namespace Mod8Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graphs mygraph = new Graphs(5);// 5 vertices
            mygraph.insertEdge(0, 1, 1);
            mygraph.insertEdge(1, 2, 1);
            mygraph.insertEdge(2,3, 1);
            mygraph.insertEdge(1, 3, 1);
            mygraph.insertEdge(0, 2, 1);
            mygraph.insertEdge(1,0, 1);
            mygraph.display();
            mygraph.edges();
            mygraph.BFS(0);

            Graphs g = new Graphs(7);
            g.insertEdge(0, 1, 1);
            g.insertEdge(0, 5, 1);
            g.insertEdge(0, 6, 1);
            g.insertEdge(1, 0, 1);
            g.insertEdge(1, 2, 1);
            g.insertEdge(1, 5, 1);
            g.insertEdge(1, 6, 1);
            g.insertEdge(2, 3, 1);
            g.insertEdge(2, 4, 1);
            g.insertEdge(2, 6, 1);
            g.insertEdge(3, 4, 1);
            g.insertEdge(4, 2, 1);
            g.insertEdge(4, 5, 1);
            g.insertEdge(5, 2, 1);
            g.insertEdge(5, 3, 1);
            g.insertEdge(6, 3, 1);
            Console.WriteLine("Breadth First Search:");
            g.BFS(0);
            Console.WriteLine("Depth First Search:");
            g.DFS(0);

            
            Console.ReadKey();

        }
    }
}
