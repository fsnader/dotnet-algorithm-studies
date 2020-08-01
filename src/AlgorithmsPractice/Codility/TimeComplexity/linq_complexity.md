##LINQ Methdos Complexity

O(1):
- Count
- Contains - O(n) on List / O(1) on HashSet

O(n) complexity:
- Select
- Where
- Any/All
- Other single-pass operations

O(1) on collections that implement IList<T>:
- ElementAt
- Take/Skip
- Last
- LastOrDefault

Closer to O(n) instead of O(n^2)
- GroupBy
- Join

O(N log N)
- OrderBy/ThenBy: Uses stable quicksort
Obs.: The LINQ OrderBy(...).ThenBy(...)...ThenBy(...) method chain form a single sort operation by multiple sort keys (using multi key comparer).


O(n+m)
- Union
- Intersect
- Except


Tips: Calling ToList() avoid complexity increasing

----------
n <= 1.000.000.000 -> Must be C
n <= 1.000.000 -> Must be O(n) or O(n log n)
n <= 10.000 -> Must be O(n^2)
n <= 500 -> Must be O(n^3)