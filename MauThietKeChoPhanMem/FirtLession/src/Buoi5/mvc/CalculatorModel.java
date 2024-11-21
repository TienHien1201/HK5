package Buoi5.mvc;

import Buoi5.mvc.observer.Publisher;

public class CalculatorModel extends Publisher {
    private double result;

    public void add(double a, double b) {
        this.result = a + b;
        chaneState();
    }

    public void subtract(double a, double b) {
        this.result = a - b;
        chaneState();

    }

    public void multiply(double a, double b) {
        this.result = a * b;
        chaneState();

    }

    public void divide(double a, double b) {
        this.result = a / b;
        chaneState();

    }

    public double getresult() {
        return result;
    }

    public void chaneState() {
        notifySubcribers();
        
    }
}
