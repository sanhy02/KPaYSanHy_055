using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main()
        {
            Sinhvien sv1 = new Sinhvien();
            Console.WriteLine("Nhap thong tin sinh vien 1:");
            Console.Write("Ho ten:");
            sv1.Hoten = Console.ReadLine();
            Console.Write("Diem Toan: ");
            sv1.Diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Diem Van: ");
            sv1.Diemvan = double.Parse(Console.ReadLine());
            Console.Write("Diem Ngoai Ngu: ");
            sv1.Diemngoaingu = double.Parse(Console.ReadLine());
            Console.Write("Khoi hoc (A,B,C): ");
            sv1.Khoihoc = char.Parse(Console.ReadLine());
            sv1.InThongTin();
            Sinhvien sv2 = new Sinhvien("Nguyen Van B", 7.5,8.0,6.0, 'B');
            sv2.InThongTin();
            Console.ReadLine();
        }
    }

}
