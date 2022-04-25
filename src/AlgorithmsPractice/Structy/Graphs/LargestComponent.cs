using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Structy.Graphs
{
    // https://structy.net/problems/largest-component
    public static class LargestComponent
    {
        public static int GetLargest(Dictionary<int, List<int>> graph)
        {
            var visited = new HashSet<int>();

            var biggest = 0;

            foreach (var node in graph)
            {
                var size = Explore(graph, node.Key, visited);
                if (size >= biggest)
                {
                    biggest = size;
                }
            }

            return biggest;
        }

        private static int Explore(
            Dictionary<int, List<int>> graph,
            int current,
            HashSet<int> visited)
        {
            if (visited.Contains(current))
            {
                return 0;
            }

            visited.Add(current);
            var size = 1;

            foreach (var neighbor in graph[current])
            {
                size += Explore(graph, neighbor, visited);
            }

            return size;
        }
    }
}
