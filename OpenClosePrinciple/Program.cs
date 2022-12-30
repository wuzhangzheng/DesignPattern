// See https://aka.ms/new-console-template for more information


using OpenClosePrinciple;
using OpenClosePrinciple.Classes;
using OpenClosePrinciple.Interface;

var ultramanFactory= new UltramanFactory();
IUltraman ultraman= ultramanFactory.CreateUltraman(UltramanType.Ace);
if (ultraman is Ace)
{
    System.Console.WriteLine("我是艾斯");
}
else
{
    System.Console.WriteLine("我什么也不是");
}

Console.WriteLine("Hello, World!");
