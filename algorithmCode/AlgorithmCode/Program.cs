using AlgorithmCode.ACM;
using AlgorithmCode.Array;
using AlgorithmCode.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Maze.Solve();
            Console.WriteLine("");
            Console.WriteLine("Shortest path:"+ res.ToString());
        }
    }
}
