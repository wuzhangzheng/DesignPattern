using OpenClosePrincipleTest.Classes;
using OpenClosePrincipleTest.Interface;

namespace OpenClosePrincipleTest;

public class AceFactory : IUltramanFactory
{
    public IUltraman CreateUltraman()
    {
        return new Ace();
    }
}
