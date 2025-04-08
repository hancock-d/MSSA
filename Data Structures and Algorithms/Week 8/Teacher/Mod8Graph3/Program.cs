using System;
using System.Collections.Generic;
class WeightedDirectedGraph
{
    // Dictionary to store the adjacency list with weights
    private Dictionary<int, List<(int destination, int weight)>> //creating list with 2 paramenters: destination (edge connected to) and weight
   adjacencyList;
    public WeightedDirectedGraph() //constructor
    {
        adjacencyList = new Dictionary<int, List<(int, int)>>();
    }
    // Add a vertex to the graph
    public void AddVertex(int vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<(int, int)>();
        }
    }
    // Add a directed edge with a weight
    public void AddEdge(int vertex1, int vertex2, int weight)
    {
        if (!adjacencyList.ContainsKey(vertex1))
        {
            AddVertex(vertex1);
        }
        if (!adjacencyList.ContainsKey(vertex2))
        {
            AddVertex(vertex2);
        }
        adjacencyList[vertex1].Add((vertex2, weight));
    }
    // Display the graph
    public void DisplayGraph()
    {
        foreach (var vertex in adjacencyList)
        {
            Console.Write($"{vertex.Key}: ");
            foreach (var edge in vertex.Value)
            {
                Console.Write($"-> ({edge.destination}, Weight:{ edge.weight}) ");
            }
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        WeightedDirectedGraph graph = new WeightedDirectedGraph();
        // Add weighted edges
        graph.AddEdge(1, 2, 5); //add an edge between 1 and 2, weight of 5
        graph.AddEdge(1, 3, 10);
        graph.AddEdge(2, 3, 2);
        graph.AddEdge(3, 4, 8);
        graph.AddEdge(4, 5, 3);
        // Display the graph
        Console.WriteLine("Weighted Directed Graph:");
        graph.DisplayGraph();
        Console.ReadKey();
    }
}

