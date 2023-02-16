#region Problem
/*
You are given a matrix of order N*N having 1's and 0's written as its elements. 
Now, imagine that there is a rat at (0,0) and he needs to reach the destination at (N-1, N-1). 
You need to provide the paths for the rat to reach the destination. 
Now, 1 means that you can go through the element but 0 means that you cannot. 
Also, you need to take care of the fact that you can either go 
up(U), down(D), left(L), or right(R). Print the possible paths.
*/
#endregion

#region Solution

namespace RatInMaze;

public class Program
{
    public static void Main()
    {
        /*int[, ] matrix = { 
            { 1, 0, 0, 0 }, 
            { 1, 1, 0, 1 }, 
            { 1, 1, 0, 0 }, 
            { 0, 1, 1, 1 } 
        };*/

        int[,] matrix = {
                { 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 0, 1, 1 }
        };

        new Problem(matrix).Solve();
    }
}

#endregion
