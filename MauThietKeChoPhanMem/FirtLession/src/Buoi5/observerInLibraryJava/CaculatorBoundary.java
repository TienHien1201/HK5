package Buoi5.observerInLibraryJava;
import java.util.Observable;
import java.util.Observer;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class CaculatorBoundary extends JFrame implements Observer {
    private JPanel jPanelRemote;
    private JLabel jLabelInputRemote1, jLabelInputRemote2, jLabelOutputRemote;
    public JLabel getjLabelInputRemote1() {
        return jLabelInputRemote1;
    }

    public JLabel getjLabelInputRemote2() {
        return jLabelInputRemote2;
    }

    public JLabel getjLabelOutputRemote() {
        return jLabelOutputRemote;
    }

    private JTextField jTextFieldInputRemote1, jTextFieldInputRemote2;
    public JTextField getjTextFieldInputRemote1() {
        return jTextFieldInputRemote1;
    }

    public JTextField getjTextFieldInputRemote2() {
        return jTextFieldInputRemote2;
    }

    private JButton addButton, suButton, divButton, muButton;
    private CaculatorControl caculatorControlRemote;

    public CaculatorBoundary(CaculatorControl caculatorControlRemote) {
        this.caculatorControlRemote = caculatorControlRemote;
        buildPanel();
    }

    public void buildPanel() {
        jPanelRemote = new JPanel();
        jLabelInputRemote1 = new JLabel("input1");
        jPanelRemote.add(jLabelInputRemote1);
        jTextFieldInputRemote1 = new JTextField(10);
        jPanelRemote.add(jTextFieldInputRemote1);
        jLabelInputRemote2 = new JLabel("input2");
        jPanelRemote.add(jLabelInputRemote2);
        jTextFieldInputRemote2 = new JTextField(10);
        jPanelRemote.add(jTextFieldInputRemote2);
        jLabelOutputRemote = new JLabel("output");
        jPanelRemote.add(jLabelOutputRemote);
        addButton = new JButton("ADD");
        addButton.addActionListener(caculatorControlRemote);
        jPanelRemote.add(addButton);

        suButton = new JButton("sub");
        suButton.addActionListener(caculatorControlRemote);
        jPanelRemote.add(suButton);

        muButton = new JButton("mu");
        muButton.addActionListener(caculatorControlRemote);
        jPanelRemote.add(muButton);

        divButton = new JButton("div");
        divButton.addActionListener(caculatorControlRemote);
        jPanelRemote.add(divButton);
        setSize(400, 400);
        setVisible(true);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        add(jPanelRemote);
    }

    @Override
    public void update(Observable o, Object arg) {
        if (o instanceof CaculatorEntity) {
            double result = (double) arg;
            jLabelOutputRemote.setText("" + result);
        }
    }

    // Getter and setter methods
    // ...
}

