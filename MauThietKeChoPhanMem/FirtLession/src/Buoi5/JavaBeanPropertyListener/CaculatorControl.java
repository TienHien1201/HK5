package Buoi5.JavaBeanPropertyListener;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;

public class CaculatorControl implements ActionListener, PropertyChangeListener {
    private CaculatorEntity caculatorEntityRemote;
    private CaculatorBoundary caculatorBoundaryRemote;

    public CaculatorControl() {
        caculatorBoundaryRemote = new CaculatorBoundary(this);
        caculatorEntityRemote = new CaculatorEntity();
        caculatorEntityRemote.addPropertyChangeListener(this);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        String command = e.getActionCommand();
        double num1 = Double.parseDouble(caculatorBoundaryRemote.getjTextFieldInputRemote1().getText());
        double num2 = Double.parseDouble(caculatorBoundaryRemote.getjTextFieldInputRemote2().getText());

        if (command.equals("ADD")) {
            caculatorEntityRemote.add(num1, num2);
        } else if (command.equals("sub")) {
            caculatorEntityRemote.sub(num1, num2);
        } else if (command.equals("div")) {
            caculatorEntityRemote.div(num1, num2);
        } else if (command.equals("mu")) {
            caculatorEntityRemote.mu(num1, num2);
        }
    }

    @Override
    public void propertyChange(PropertyChangeEvent evt) {
        if ("result".equals(evt.getPropertyName())) {
            double result = (double) evt.getNewValue();
            caculatorBoundaryRemote.getjLabelOutputRemote().setText("" + result);
        }
    }
}
