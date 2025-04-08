using System;
using System.Collections.Generic;
class DirectedGraph
{
    // Dictionary to store the adjacency list
    private Dictionary<int, List<int>> adjacencyList;
    public DirectedGraph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }
    // Add a vertex to the graph
    public void AddVertex(int vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<int>();
        }
    }
    // Add a directed edge from vertex1 to vertex2
    public void AddEdge(int vertex1, int vertex2)
    {
        if (!adjacencyList.ContainsKey(vertex1))
        {
            AddVertex(vertex1);
        }
        if (!adjacencyList.ContainsKey(vertex2))
        {
            AddVertex(vertex2);
        }
        adjacencyList[vertex1].Add(vertex2); // Only add the edge in one direction (only difference in directed vs undirected), not adding reverse edge
    }
    public void DisplayGraph()
    {
        foreach (var vertex in adjacencyList)
        {
            Console.Write($"{vertex.Key}: ");
            foreach (var neighbor in vertex.Value)
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DirectedGraph graph = new DirectedGraph();
        // Add edges
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        // Display the graph
        Console.WriteLine("Directed Graph:");
        graph.DisplayGraph();
        Console.ReadKey();
    }
}
