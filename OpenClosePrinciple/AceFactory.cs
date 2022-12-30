using OpenClosePrinciple.Classes;
using OpenClosePrinciple.Interface;

namespace OpenClosePrinciple;

public class AceFactory : IUltramanFactory
{
    public IUltraman CreateUltraman()
    {
        return new Ace();
    }
}
