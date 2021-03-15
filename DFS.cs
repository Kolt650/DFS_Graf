using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFC
{
    public class DFS
    {
        
        public Stack<int> stack = new Stack<int>();

        public void search( Node node, int value)
        {
            int queueElement;
            int i = 0;
            if (node.Visited == false)
            {
                node.Visited = true;
                stack.Push(node.Count);
                if (stack != null)
                {
                    queueElement = stack.Pop();
                    if (queueElement == value)
                        Console.WriteLine("Элемент найден, его имя " + node.Name);
                    else
                        search(node.Edges[i].Node, value);
                }
                else
                    Console.WriteLine("Очередь пуста");
            }
            else
                Console.WriteLine ("Visited");
        }
    }
}
