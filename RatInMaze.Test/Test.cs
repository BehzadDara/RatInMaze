using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatInMaze.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test1()
        {
            int[,] matrix = {
                { 1, 0, 0, 0 },
                { 1, 1, 0, 1 },
                { 1, 1, 0, 0 },
                { 0, 1, 1, 1 }
            };

            var result = new Problem(matrix).Solve();

            Assert.IsTrue(result.Count == 2);

            var firstResult = new List<Tuple<int, int>>{
                new Tuple < int, int >(0, 0),
                new Tuple < int, int >(1, 0),
                new Tuple < int, int >(1, 1),
                new Tuple < int, int >(2, 1),
                new Tuple < int, int >(3, 1),
                new Tuple < int, int >(3, 2),
                new Tuple < int, int >(3, 3)
            };
            Assert.IsTrue(firstResult.SequenceEqual(result.First()));

            var lastResult = new List<Tuple<int, int>>{
                new Tuple < int, int >(0, 0),
                new Tuple < int, int >(1, 0),
                new Tuple < int, int >(2, 0),
                new Tuple < int, int >(2, 1),
                new Tuple < int, int >(3, 1),
                new Tuple < int, int >(3, 2),
                new Tuple < int, int >(3, 3)
            };
            Assert.IsTrue(lastResult.SequenceEqual(result.Last()));
        }
        
        [TestMethod]
        public void Test2()
        {
            int[,] matrix1 = {
                { 1, 1 },
                { 1, 1 }
            };

            var result1 = new Problem(matrix1).Solve();

            Assert.IsTrue(result1.Count == 2);
            
            int[,] matrix2 = {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            var result2 = new Problem(matrix2).Solve();

            Assert.IsTrue(result2.Count == 12);
            
            int[,] matrix3 = {
                { 1, 0, 1 },
                { 1, 1, 0 },
                { 1, 0, 1 }
            };

            var result3 = new Problem(matrix3).Solve();

            Assert.IsTrue(result3.Count == 0);
            
            int[,] matrix4 = {
                { 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 0, 1, 1 }
            };

            var result4 = new Problem(matrix4).Solve();

            Assert.IsTrue(result4.Count == 2);



        }
        
        [TestMethod]
        public void Test3()
        {
            int[,] matrix = {
                { 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 0, 1, 1 }
            };

            var result = new Problem(matrix).Solve();

            Assert.IsTrue(result.Count == 2);

            var firstResult = new List<Tuple<int, int>>{
                new Tuple < int, int >(0, 0),
                new Tuple < int, int >(1, 0),
                new Tuple < int, int >(2, 0),
                new Tuple < int, int >(2, 1),
                new Tuple < int, int >(2, 2),
                new Tuple < int, int >(2, 3),
                new Tuple < int, int >(2, 4),
                new Tuple < int, int >(3, 4),
                new Tuple < int, int >(4, 4)
            };
            Assert.IsTrue(firstResult.SequenceEqual(result.First()));

            var lastResult = new List<Tuple<int, int>>{
                new Tuple < int, int >(0, 0),
                new Tuple < int, int >(1, 0),
                new Tuple < int, int >(2, 0),
                new Tuple < int, int >(2, 1),
                new Tuple < int, int >(2, 2),
                new Tuple < int, int >(1, 2),
                new Tuple < int, int >(0, 2),
                new Tuple < int, int >(0, 3),
                new Tuple < int, int >(0, 4),
                new Tuple < int, int >(1, 4),
                new Tuple < int, int >(2, 4),
                new Tuple < int, int >(3, 4),
                new Tuple < int, int >(4, 4)
            };
            Assert.IsTrue(lastResult.SequenceEqual(result.Last()));

        }

    }
}
