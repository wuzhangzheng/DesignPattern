// See https://aka.ms/new-console-template for more information
using OpenClosePrincipleTest;
using OpenClosePrincipleTest.Classes;

var ultraman=new AceFactory().CreateUltraman();

if (ultraman is Ace)
{
    System.Console.WriteLine("我是ACE");    
}
else
{
    System.Console.WriteLine("我不是ACE");
}

Console.WriteLine("Hello, World!");
