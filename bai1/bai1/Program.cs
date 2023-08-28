using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td2 = new ToaDo(2, 3, "A");
            Console.WriteLine(td2.toString());
            td2.setx(5);
            td2.sety(7);
            td2.setten("B");
            Console.WriteLine(td2.toString());
            Console.ReadLine();
        }
    }
}
