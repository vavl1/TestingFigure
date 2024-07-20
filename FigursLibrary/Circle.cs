using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
    public class Circle : IFigure
    {
        public int R { get; set; }
        public double GetSquare()
        {
           return Math.Round(Math.PI* (R*R),2);
        }
    }
}
