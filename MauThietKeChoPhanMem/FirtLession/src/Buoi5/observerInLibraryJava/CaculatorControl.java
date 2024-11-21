package Buoi5.observerInLibraryJava;
import java.util.Observable;
import java.util.Observer;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class CaculatorControl implements ActionListener, Observer {
    private CaculatorEntity caculatorEntityRemote;
    private CaculatorBoundary caculatorBoundaryRemote;

    public CaculatorControl() {
        caculatorBoundaryRemote = new CaculatorBoundary(this);
        caculatorEntityRemote = new CaculatorEntity();
        caculatorEntityRemote.addObserver(this);
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
    public void update(Observable o, Object arg) {
        if (o instanceof CaculatorEntity) {
            double result = (double) arg;
            caculatorBoundaryRemote.getjLabelOutputRemote().setText("" + result);
        }
    }
}

