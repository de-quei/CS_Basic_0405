﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Basic_0405
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            // C#에서도 헬로월드를?
            Console.WriteLine("Hello World?!");

            // overflow prac
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);

            //overflow prac2
            Console.WriteLine((long)a + b);
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);
        }
    }
}
