using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Structy.Graphs
{
    // https://structy.net/problems/connected-components-count
    public static class ConnectedComponentsCount
    {
        public static int Count(Dictionary<int, List<int>> graph)
        {
            var visited = new HashSet<int>();
            int count = 0;

            foreach (var node in graph)
            {
                if (Explore(graph, node.Key, visited))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool Explore(
            Dictionary<int, List<int>> graph,
            int current,
            HashSet<int> visited)
        {
            if (visited.Contains(current))
            {
                return false;
            }

            visited.Add(current);

            foreach (var neighbor in graph[current])
            {
                Explore(graph, neighbor, visited);
            }

            return true;
        }

    }
}
