class CalculationAdd{
    leftNumber=0;
    rightNumber=0;
    getResult()
    {
        return this.leftNumber+this.rightNumber;
    }
}
class CalculationSub{
    leftNumber=0;
    rightNumber=0;
    getResult()
    {
        return this.leftNumber-this.rightNumber;
    }
}
class factoryCalculation{
    static getCalculation(left,right,operater){
        switch (operater) {
            case "+":
                let add=new CalculationAdd();
                add.leftNumber=left;
                add.rightNumber=right;
                return add;
            case "-":
                let sub=new CalculationSub();
                sub.leftNumber=left;
                sub.rightNumber=right;
                return sub;    
            default:
                return null;
        }
    }
}

let add = factoryCalculation.getCalculation(1, 2, "+");
console.log(add.getResult());
let sub = factoryCalculation.getCalculation(1, 2, "-");
console.log(sub.getResult());