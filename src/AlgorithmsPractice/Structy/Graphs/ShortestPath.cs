using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Structy.Graphs
{
    public static class ShortestPath
    {
        public static Dictionary<char, List<char>> GetGraph(char[][] edges)
        {
            var graph = new Dictionary<char, List<char>>();

            foreach (var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                {
                    graph.Add(edge[0], new List<char>());

                }

                if (!graph.ContainsKey(edge[1]))
                {
                    graph.Add(edge[1], new List<char>());
                }

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            return graph;
        }

        public static int GetShortestPath(char[][] edges, char from, char to)
        {
            return GetShortestPath(GetGraph(edges), from, to);
        }

        public static int GetShortestPath(Dictionary<char, List<char>> graph, char from, char to)
        {
            var queue = new Queue<(char, int)>();
            var visited = new HashSet<char>();
            visited.Add(from);
            queue.Enqueue((from, 0));


            while (queue.Count > 0)
            {
                (var node, var distance) = queue.Dequeue();

                if (node == to)
                {
                    return distance;
                }

                foreach (var neighbor in graph[node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue((neighbor, distance + 1));
                    }
                }
            }

            return -1;
        }
    }
}
