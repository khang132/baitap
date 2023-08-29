using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class ToaDo
    {
        private double x;
        private double y;
        private string ten;

        public double getx()
        {
           return x;
        }
        public void setx(double x)
        {
            this.x = x;
        }
        public double gety()
        {
            return y;
        }
        public void sety(double y)
        {
            this.y = y;
        }
        public string getten()
        {
            return ten;
        }
        public void setten(string ten)
        {
            this.ten = ten;
        }
        public ToaDo()
        {
        }
        public ToaDo(double x, double y, string ten)
        {
            this.x = x;
            this.y = y;
            this.ten = ten;
        }
        public String toString()
        {
            return ten + " (" + x + ", " + y + ")";
        }
    }
}
