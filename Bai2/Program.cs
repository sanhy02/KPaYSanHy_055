﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] age)
        {
            Console.WriteLine("Tinh Chu vi va Dien Tich Hinh Vuong & Chu Nhat");
            ChuNhat cn = new ChuNhat(221,315 );
            ChuNhat vu = new Vuong(202);
            cn.Xuat();
            vu.Xuat();
            Console.ReadLine();
        }
    }
}