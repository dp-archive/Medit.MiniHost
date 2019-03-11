﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medit.MiniHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new PlayServiceHost())
            {
                host.OpenService();
                Console.ReadKey();
            }
        }
    }
}
