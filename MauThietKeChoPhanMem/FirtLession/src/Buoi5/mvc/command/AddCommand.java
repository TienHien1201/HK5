package Buoi5.mvc.command;

import Buoi5.mvc.CalculatorModel;

public class AddCommand extends Command {
    private double num1,num2;
public AddCommand(double num1, double num2,  CalculatorModel calculatorModelRemote){
   this.calculatorModelRemote = calculatorModelRemote;
    this.num1 = num1;
    this.num2 = num2;
}


    @Override
    public void excute() {
        // TODO Auto-generated method stub
    calculatorModelRemote.add(num1, num2);
    }

}
