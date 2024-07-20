using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
    public class Triagle : IFigure
    {
        public int A { get;set; }
        public int B { get; set; }
        public int C { get; set; }

        public double GetSquare()
        {
            if (A + B <= C || A + C <= B || B + C <= A)
                return 0;
            int p = (A + B + C)/2;
            return Math.Round(Math.Sqrt(p*(p-A)*(p-B)*(p-C)),2);
        }
        public bool IsRegtangular()
        {
            int[] nums = new int[] { A, B, C }.OrderByDescending(i=>i).ToArray();
            if ((nums[1]* nums[1]) + (nums[2]*nums[2]) == (nums[0]*nums[0]) ) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
