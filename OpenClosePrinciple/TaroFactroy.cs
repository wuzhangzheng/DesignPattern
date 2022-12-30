using OpenClosePrinciple.Classes;
using OpenClosePrinciple.Interface;

namespace OpenClosePrinciple;

public class TaroFactroy : IUltramanFactory
{
    

    public IUltraman CreateUltraman()
    {
        return new Taro();
    }
}
