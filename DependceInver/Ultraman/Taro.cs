namespace DependceInver.Ultraman;

public class Taro : IUltraman
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public void Attack()
    {
        throw new NotImplementedException();
    }
}