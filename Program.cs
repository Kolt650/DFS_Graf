using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFC
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[500, 500];

            //////////////////////////////////////Создание ячеек//////////////////////////////////////////////

            var nodeA = new Node()
            {
                Name = "A",
                Count = 5,
                Edges = new List<Edge>()
            };

            var nodeB = new Node()
            {
                Name = "B",
                Count = 4,
                Edges = new List<Edge>()
            };

            var nodeC = new Node()
            {
                Name = "C",
                Count = 3,
                Edges = new List<Edge>()
            };

            var nodeD = new Node()
            {
                Name = "D",
                Count = 2,
                Edges = new List<Edge>()
            };

            var nodeE = new Node()
            {
                Name = "E",
                Count = 1,
                Edges = new List<Edge>()
            };

            ////////////////////////////////////Создание путей между ячейками/////////////////////////////////////

            nodeA.Edges.Add(new Edge
            {
                Node = nodeB,
                Weight = 4
            });

            nodeB.Edges.Add(new Edge
            {
                Node = nodeC,
                Weight = 6
            });

            nodeC.Edges.Add(new Edge
            {
                Node = nodeD,
                Weight = 2
            });

            nodeD.Edges.Add(new Edge
            {
                Node = nodeE,
                Weight = 1
            });

            nodeE.Edges.Add(new Edge
            {
                Node = nodeA,
                Weight = 5
            });

            //////////////////////////////////////BFS обход графа/////////////////////////////////////

            int x = 2;
            DFS dfs = new DFS();
            dfs.search(nodeA,x);
            Console.WriteLine("Конец работы");
            Console.ReadKey();
        }
    }
}
