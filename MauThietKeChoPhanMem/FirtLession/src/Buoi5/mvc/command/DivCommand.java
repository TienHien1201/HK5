package Buoi5.mvc.command;

import Buoi5.mvc.CalculatorModel;

public class DivCommand extends Command  {
    private double num1,num2;
public DivCommand(double num1, double num2, CalculatorModel calculatorModelRemote) {
        this.num1 = num1;
        this.num2 = num2;
        this.calculatorModelRemote = calculatorModelRemote;
    }

    @Override
    public void excute() {
       calculatorModelRemote.divide( num1,num2);
    }

}
