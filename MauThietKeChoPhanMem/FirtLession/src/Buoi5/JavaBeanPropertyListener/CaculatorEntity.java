package Buoi5.JavaBeanPropertyListener;
import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;

public class CaculatorEntity {
    private double result;
    private PropertyChangeSupport support;

    public CaculatorEntity() {
        support = new PropertyChangeSupport(this);
    }

    public void add(double a, double b) {
        double oldResult = this.result;
        this.result = a + b;
        support.firePropertyChange("result", oldResult, this.result);
    }

    public void sub(double a, double b) {
        double oldResult = this.result;
        this.result = a - b;
        support.firePropertyChange("result", oldResult, this.result);
    }

    public void mu(double a, double b) {
        double oldResult = this.result;
        this.result = a * b;
        support.firePropertyChange("result", oldResult, this.result);
    }

    public void div(double a, double b) {
        double oldResult = this.result;
        this.result = a / b;
        support.firePropertyChange("result", oldResult, this.result);
    }

    public double getResult() {
        return result;
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        support.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        support.removePropertyChangeListener(listener);
    }
}
