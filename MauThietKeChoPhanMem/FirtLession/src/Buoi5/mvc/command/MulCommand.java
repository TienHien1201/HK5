package Buoi5.mvc.command;

import Buoi4.CaculatorModel;
import Buoi5.mvc.CalculatorModel;

public class MulCommand extends Command{
    private double num1, num2;
public MulCommand(double num1, double num2, CalculatorModel caculatorModelRemote) {
        this.num1 = num1;
        this.num2 = num2;
         this.calculatorModelRemote = caculatorModelRemote;
    }



    @Override
    public void excute() {
       calculatorModelRemote.subtract(num1, num2);
    }

}
