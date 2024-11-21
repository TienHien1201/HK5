package Buoi5.mvc.command;

import Buoi5.mvc.CalculatorModel;

public abstract class Command {
protected CalculatorModel calculatorModelRemote = null;

//Có than k có dau để thân nó cho con nó dinh nghia
public abstract void excute();
}
