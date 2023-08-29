using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{

    class Program
    {
        static void Main(string[] args)
        {
            Student sv1 = new Student()
            {
                MSSV = 123,
                HoTen = "Nguyen Thanh An",
                DiemLT = 8.5f,
                DiemTH = 9.0f
            };
            Student sv2 = new Student()
            {
                MSSV = 456,
                HoTen = "Le Thi Bong",
                DiemLT = 7.0f,
                DiemTH = 8.0f
            };
            Student sv3 = new Student();
            Console.Write("nhap ma so cua sinh vien sv3: ");
            sv3.MSSV = int.Parse(Console.ReadLine());
            Console.Write("nhap ho va ten cua sinh vien sv3: ");
            sv3.HoTen = Console.ReadLine();
            Console.Write("nhap diem ly thuyet cua sinh vien sv3: ");
            sv3.DiemLT = float.Parse(Console.ReadLine());
            Console.Write("nhap diem thuc hanh cua nhanh vien sv3: ");
            sv3.DiemTH = float.Parse(Console.ReadLine());
            Console.WriteLine("mssv            hoten                diemlt     diemlt     diemtb");
            Console.WriteLine("" + sv1.ToString());
            Console.WriteLine("" + sv2.ToString());
            Console.WriteLine("" + sv3.ToString());
            Console.ReadLine();
        }
    }


}
