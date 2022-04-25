using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Structy.Graphs
{
    public static class IslandCount
    {
        public static int GetCount(char[][] grid)
        {
            var visited = new HashSet<string>();
            var islands = 0;

            for (int rowIndex = 0; rowIndex < grid.Length; rowIndex++)
            {
                var row = grid[rowIndex];
                for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
                {
                    if (WalkIsland(rowIndex, columnIndex, grid, visited) > 0)
                    {
                        islands++;
                    }
                }
            }

            return islands;
        }

        public static int GetSmallestIsland(char[][] grid)
        {
            var visited = new HashSet<string>();
            var minimum = 0;

            for (int rowIndex = 0; rowIndex < grid.Length; rowIndex++)
            {
                var row = grid[rowIndex];
                for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
                {
                    var size = WalkIsland(rowIndex, columnIndex, grid, visited);
                    if (size > 0 && (size < minimum || minimum == 0))
                    {
                        minimum = size;
                    }
                }
            }

            return minimum;
        }

        private static int WalkIsland(int row, int column, char[][] grid, HashSet<string> visited)
        {
            var rowInbounds = 0 <= row && row < grid.Length;
            var columnInbounds = 0 <= column && column < grid[0].Length;

            if (!rowInbounds || !columnInbounds)
            {
                return 0;
            }

            if (grid[row][column] == 'W')
            {
                return 0;
            }

            if (visited.Contains($"{row}:{column}"))
            {
                return 0;
            }

            visited.Add($"{row}:{column}");

            return 
                WalkIsland(row - 1, column, grid, visited) +
                WalkIsland(row + 1, column, grid, visited) +
                WalkIsland(row, column - 1, grid, visited) +
                WalkIsland(row, column + 1, grid, visited) + 1;
        }
    }
}
