using System;
class AdjacencyMatrixGraph
{
    private int[,] adjacencyMatrix; // 2D array to store edges and respective values
    private int vertexCount;
    public AdjacencyMatrixGraph(int vertices)
    {
        vertexCount = vertices;
        adjacencyMatrix = new int[vertexCount, vertexCount];
    }
    // Add an edge to the graph
    public void AddEdge(int vertex1, int vertex2, int weight = 1) //pass vertex 1, vertex 2, and weight. Weight will be 1 by default if no weight added
    {
        adjacencyMatrix[vertex1, vertex2] = weight; // Set weight for the edge
    }
    // Remove an edge from the graph
    public void RemoveEdge(int vertex1, int vertex2) //remove connection between nodes
    {
        adjacencyMatrix[vertex1, vertex2] = 0; // Set weight to 0 (no edge)
    }
    // Display the adjacency matrix
    public void DisplayGraph()
    {
        Console.WriteLine("Adjacency Matrix:");
        for (int i = 0; i < vertexCount; i++)
        {
            for (int j = 0; j < vertexCount; j++)
            {
                Console.Write(adjacencyMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a graph with 5 vertices
        AdjacencyMatrixGraph graph = new AdjacencyMatrixGraph(5);
        // Add edges with weights
        graph.AddEdge(0, 1, 5); // Edge from vertex 0 to vertex 1 with weight 5
        graph.AddEdge(0, 2, 10); // Edge from vertex 0 to vertex 2 with  weight 10
        graph.AddEdge(1, 2, 2); // Edge from vertex 1 to vertex 2 with weight  2
        graph.AddEdge(2, 3, 8); // Edge from vertex 2 to vertex 3 with weight  8
        graph.AddEdge(3, 4, 3); // Edge from vertex 3 to vertex 4 with weight 3
                                // Display the adjacency matrix
        graph.DisplayGraph();
        Console.ReadKey();
    }
}