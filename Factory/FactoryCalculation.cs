namespace Factory;

public class FactoryCalculation
{
     public static ICalculation CreateCalculationAdd(int leftNumber, int rightNumber,string opterator=null)
     {
          switch (opterator)
          {
               default:
               case "+" :
                    var add= new CalculationAdd();
                    add.LeftNumber = leftNumber;
                    add.RightNumber = rightNumber;
                    return add;
               case "-":
                    var sub= new CalculationSub();
                    sub.LeftNumber = leftNumber;
                    sub.RightNumber = rightNumber;
                    return sub;
              
                    
          }
     }
}