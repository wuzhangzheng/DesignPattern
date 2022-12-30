using OpenClosePrincipleTest.Classes;
using OpenClosePrincipleTest.Interface;

namespace OpenClosePrincipleTest;

public class TaroFactory : IUltramanFactory
{
    public IUltraman CreateUltraman()
    {
        return new Taro();
    }
}
