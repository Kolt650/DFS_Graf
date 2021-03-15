using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFC
{
    public class Node //Вершина
    {
        public string Name { get; set; } //Имя
        public int Count { get; set; } //Число
        public bool Visited { get; set; } // Посещаемость
        public List<Edge> Edges { get; set; } //исходящие связи
    }

}
