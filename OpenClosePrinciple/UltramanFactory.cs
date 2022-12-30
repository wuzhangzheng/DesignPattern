using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenClosePrinciple.Classes;
using OpenClosePrinciple.Interface;

namespace OpenClosePrinciple
{
    public class UltramanFactory
    {
        // public Ace CreateAce()
        // {
        //     return new Ace();
        // }
        // public Taro CreateTaro()
        // {
        //     return new Taro();
        // }
        public IUltraman CreateUltraman(UltramanType ultramanType)
        {
            switch (ultramanType)
            {
                default:
                case UltramanType.Ace:
                    return new Ace();
                case UltramanType.Taro:
                    return new Taro();                
            }
        }
    }
}