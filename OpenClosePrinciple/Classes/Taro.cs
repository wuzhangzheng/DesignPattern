using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenClosePrinciple.Interface;

namespace OpenClosePrinciple.Classes
{
    public class Taro:IUltraman
    {
        public Taro()
        {
            System.Console.WriteLine("我是泰罗");
        }
    }
}