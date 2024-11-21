package Buoi5.mvc.command;

import Buoi5.mvc.CalculatorModel;

public class SubCommand extends Command {
    private double num1, num2;
    
    
    public SubCommand(double num1, double num2, CalculatorModel calculatorModelRemote) {
            this.num1 = num1;
            this.num2 = num2;
            this.calculatorModelRemote = calculatorModelRemote;
        }


    @Override
    public void excute() {
        // TODO Auto-generated method stub
       calculatorModelRemote.subtract(num1, num2);
    }

}
