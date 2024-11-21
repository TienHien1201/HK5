package Buoi5.observerInLibraryJava;
import java.util.Observable;

public class CaculatorEntity extends Observable {
    private double result;

    public void add(double a, double b) {
        this.result = a + b;
        setChanged();
        notifyObservers(result);
    }

    public void sub(double a, double b) {
        this.result = a - b;
        setChanged();
        notifyObservers(result);
    }

    public void mu(double a, double b) {
        this.result = a * b;
        setChanged();
        notifyObservers(result);
    }

    public void div(double a, double b) {
        this.result = a / b;
        setChanged();
        notifyObservers(result);
    }

    public double getResult() {
        return result;
    }
}
