//Undirected Graph in C#
using System;
using System.Collections.Generic;
class UndirectedGraph
{
    // Dictionary to store the adjacency list
    private Dictionary<int, List<int>> adjacencyList; //int represents key, corresponding value part will be a list, naming that value part adjacencyList
    public UndirectedGraph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }
    // Add a vertex to the graph
    public void AddVertex(int vertex) //passing vertex (node) number to it
    {
        if (!adjacencyList.ContainsKey(vertex)) //make sure it doesn't exist in dictionary already
        {
            adjacencyList[vertex] = new List<int>(); //create list for that vertex number, but no edges are created
        }
    }
    // Add an edge between two vertices
    public void AddEdge(int vertex1, int vertex2) //specify which vertices are connected
    {
        if (!adjacencyList.ContainsKey(vertex1)) //make sure vertex/key is not present
        {
            AddVertex(vertex1); //add the vertex/key if not present
        }
        if (!adjacencyList.ContainsKey(vertex2))
        {
            AddVertex(vertex2);
        }
        //Pair the key (node/vertex) and value (vertex it's connecting it)
        adjacencyList[vertex1].Add(vertex2); //add edge between vertices --1 connected to 2 
        adjacencyList[vertex2].Add(vertex1); // Add the reverse edge for undirected graph. --2 connected to 1
    }
    public void DisplayGraph() 
    {
        foreach (var vertex in adjacencyList) //going through each key
        {
            Console.Write($"{vertex.Key}: ");
            foreach (var neighbor in vertex.Value) //for each key, print the value (connecting nodes)
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
        UndirectedGraph graph = new UndirectedGraph();
        // Add edges
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        // Display the graph
        Console.WriteLine("Undirected Graph:");
        graph.DisplayGraph();
        Console.ReadKey();
    }
}
