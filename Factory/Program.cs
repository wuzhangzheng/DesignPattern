// See https://aka.ms/new-console-template for more information

using Factory;

var add = FactoryCalculation.CreateCalculationAdd(5, 2,"+");
Console.WriteLine(add.GetResult());
// Console.WriteLine("Hello, World!");