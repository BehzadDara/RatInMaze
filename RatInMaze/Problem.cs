using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RatInMaze;

public class Problem
{
    #region Init

    private readonly int[,] _matrix;
    private readonly int _n;

    public Problem(int[,] matrix)
    {
        _matrix = matrix;
        _n = matrix.GetLength(0);
    }

    public List<List<Tuple<int, int>>> Solve()
    {
        #region Begin
        Console.WriteLine($"Paths for the rat to reach the destination:");
        #endregion

        #region Solve
        var result = FindAllPaths();
        #endregion

        #region End
        PrintResult(result);
        return result;
        #endregion
    }

    #endregion

    #region Solution

    private List<List<Tuple<int, int>>> FindAllPaths()
    {
        var path = new List<Tuple<int, int>>
        {
            new Tuple<int, int>(0,0)
        };

        return FindPaths(path);
    }

    private List<List<Tuple<int, int>>> FindPaths(List<Tuple<int, int>> path)
    {
        var result = new List<List<Tuple<int, int>>>();

        var currentPosition = path.Last();

        #region check answer
        if (currentPosition.Equals(new Tuple<int, int>(_n - 1, _n - 1)))
        {
            result.Add(path);
            return result;
        }
        #endregion

        #region right
        if (currentPosition.Item2 != _n - 1 &&
            _matrix[currentPosition.Item1, currentPosition.Item2 + 1] == 1 &&
            !path.Any(x => x.Equals(new Tuple<int, int>(currentPosition.Item1, currentPosition.Item2 + 1))))
        {
            var tmpPath = new List<Tuple<int, int>>(path)
            {
                new Tuple<int, int>(currentPosition.Item1, currentPosition.Item2 + 1)
            };

            result.AddRange(FindPaths(tmpPath));
        }
        #endregion

        #region down
        if (currentPosition.Item1 != _n - 1 && 
            _matrix[currentPosition.Item1 + 1, currentPosition.Item2] == 1 && 
            !path.Any(x => x.Equals(new Tuple<int, int>(currentPosition.Item1 + 1, currentPosition.Item2))))
        {
            var tmpPath = new List<Tuple<int, int>>(path)
            {
                new Tuple<int, int>(currentPosition.Item1 + 1, currentPosition.Item2)
            };

            result.AddRange(FindPaths(tmpPath));
        }
        #endregion

        #region left
        if (currentPosition.Item2 != 0 &&
            _matrix[currentPosition.Item1, currentPosition.Item2 - 1] == 1 &&
            !path.Any(x => x.Equals(new Tuple<int, int>(currentPosition.Item1, currentPosition.Item2 - 1))))
        {
            var tmpPath = new List<Tuple<int, int>>(path)
            {
                new Tuple<int, int>(currentPosition.Item1, currentPosition.Item2 - 1)
            };

            result.AddRange(FindPaths(tmpPath));
        }
        #endregion

        #region up
        if (currentPosition.Item1 != 0 &&
            _matrix[currentPosition.Item1 - 1, currentPosition.Item2] == 1 &&
            !path.Any(x => x.Equals(new Tuple<int, int>(currentPosition.Item1 - 1, currentPosition.Item2))))
        {
            var tmpPath = new List<Tuple<int, int>>(path)
            {
                new Tuple<int, int>(currentPosition.Item1 - 1, currentPosition.Item2)
            };

            result.AddRange(FindPaths(tmpPath));
        }
        #endregion

        return result;
    }

    #endregion

    private static void PrintResult(List<List<Tuple<int, int>>> result)
    {
        Console.WriteLine($"Total {result.Count} paths possible.");

        result.ForEach(item => Console.WriteLine("{" + string.Join(" -> ", item) + "}"));

        Console.WriteLine($"Total {result.Count} paths possible.");
    }

}