package Buoi5.mvc;

import java.awt.event.ActionEvent;

import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JTextField;

import Buoi5.mvc.command.AddCommand;
import Buoi5.mvc.command.Command;
import Buoi5.mvc.command.CommandProcessor;
import Buoi5.mvc.command.DivCommand;
import Buoi5.mvc.command.MulCommand;
import Buoi5.mvc.command.SubCommand;
import Buoi5.mvc.observer.Subrcriber;

public class CalculartorView extends JFrame implements Subrcriber {
    public JPanel jpaneRemote;
    public JLabel jlabelInputRemotel1, jLabelInputRemotel2, jLabelOnputRemote;
    public JTextField jtextfieldInputRemotel1, jtextfieldInputRemotel2;
    public JButton addButton, suButton, mulButton, divButton;
public JMenuBar menuBarRemote;


    private CalculatorModel calcualatorModelRemote;
    private CalculatorController calcualatorControllerRemote;
    private MenuController menuControllerRemote; 
    private CommandProcessor commandProcessorRemote ;

    CalculartorView() {
        calcualatorModelRemote = new CalculatorModel();
        // đăng ký subcriber - View với MOdel là Publisher
        calcualatorModelRemote.addSubcribers(this);
        calcualatorControllerRemote = new CalculatorController();
        menuControllerRemote = new  MenuController();
        commandProcessorRemote = CommandProcessor.makeCommanProcessor();
        buildMenu();
        buildPanel();
        
        setSize(400, 400);
        setTitle("Frame Viewer");
        setJMenuBar(menuBarRemote);
        setVisible(true);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        add(jpaneRemote);
    }
    public void buildMenu(){
        menuBarRemote = new JMenuBar();
        JMenu calJMenuRemote = new JMenu("Calculator");
        menuBarRemote.add(calJMenuRemote);
        JMenuItem menuItemRemoteAdd = new JMenuItem("ADD");
        menuItemRemoteAdd.addActionListener(menuControllerRemote);
        calJMenuRemote.add(menuItemRemoteAdd);
        JMenuItem menuItemRemoteSub = new JMenuItem("Sub");
        menuItemRemoteSub.addActionListener(menuControllerRemote);
        calJMenuRemote.add(menuItemRemoteSub);
        JMenuItem menuItemRemoteDiv = new JMenuItem("Div");
        menuItemRemoteDiv.addActionListener(menuControllerRemote);
        calJMenuRemote.add(menuItemRemoteDiv);
        JMenuItem menuItemRemoteMu = new JMenuItem("Mu");
        menuItemRemoteMu.addActionListener(menuControllerRemote);
        calJMenuRemote.add(menuItemRemoteMu);
        
    
    }
    
    public void buildPanel() {
        
        jpaneRemote = new JPanel();
        jlabelInputRemotel1 = new JLabel("Input 1");
        jpaneRemote.add(jlabelInputRemotel1);
        jtextfieldInputRemotel1 = new JTextField(10);
        jpaneRemote.add(jtextfieldInputRemotel1);
        jLabelInputRemotel2 = new JLabel("Input 2");
        jpaneRemote.add(jLabelInputRemotel2);
        jtextfieldInputRemotel2 = new JTextField(10);
        jpaneRemote.add(jtextfieldInputRemotel2);
        
        jLabelOnputRemote = new JLabel("Output");
        jpaneRemote.add(jLabelOnputRemote);
        addButton = new JButton("ADD");
        addButton.addActionListener(calcualatorControllerRemote);
        jpaneRemote.add(addButton);
        suButton = new JButton("Sub");
        suButton.addActionListener(calcualatorControllerRemote);
        jpaneRemote.add(suButton);
        mulButton = new JButton("Mul");
        mulButton.addActionListener(calcualatorControllerRemote);
        jpaneRemote.add(mulButton);
        divButton = new JButton("Div");
        divButton.addActionListener(calcualatorControllerRemote);
        jpaneRemote.add(divButton);
    }

    public JTextField getJtextfieldInputRemotel1() {
        return jtextfieldInputRemotel1;
    }

    public JTextField getJtextfieldInputRemotel2() {
        return jtextfieldInputRemotel2;
}
   
@Override
    public void update() {
        double result = calcualatorModelRemote.getresult();
        jLabelOnputRemote.setText("" + result);
    }

class MenuController implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent e) {
        // TODO Auto-generated method stub
                    double num1 = Double.parseDouble(
                    jtextfieldInputRemotel1.getText());
            double num2 = Double.parseDouble(jtextfieldInputRemotel2.getText());
            String command = e.getActionCommand();
            Command commandRemote = null;
            // lấy data từ input1
            if (command.equals("ADD")) {
                // calcualatorModelRemote.add(num1, num2);
                //use command pattern
                commandRemote = new AddCommand(num1, num2, calcualatorModelRemote);
                commandProcessorRemote.excute(commandRemote);
            } else if (command.equals("Sub")) {
                // calcualatorModelRemote.subtract(num1, num2);
                //use command pattern
                commandRemote = new SubCommand(num1, num2, calcualatorModelRemote);
                commandProcessorRemote.excute(commandRemote);
            }
            else if (command.equals("Mu")) {
                // calcualatorModelRemote.multiply(num1, num2);
                  //use command pattern
                commandRemote = new MulCommand(num1, num2, calcualatorModelRemote);
                commandProcessorRemote.excute(commandRemote);
            }
            else if (command.equals("Div")) {
                // calcualatorModelRemote.divide(num1, num2);
                //use command pattern
                commandRemote = new DivCommand(num1, num2, calcualatorModelRemote);
                commandProcessorRemote.excute(commandRemote);
            }
        
    }
    
}

    class CalculatorController implements ActionListener {
        CalculatorController() {
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            double num1 = Double.parseDouble(
                    jtextfieldInputRemotel1.getText());
            double num2 = Double.parseDouble(jtextfieldInputRemotel2.getText());
            String command = e.getActionCommand();
            // lấy data từ input1
            if (command.equals("ADD")) {
                calcualatorModelRemote.add(num1, num2);
            } else if (command.equals("Sub")) {
                calcualatorModelRemote.subtract(num1, num2);
            }
            else if (command.equals("Mul")) {
                calcualatorModelRemote.multiply(num1, num2);
            }
            else if (command.equals("Div")) {
                calcualatorModelRemote.divide(num1, num2);
            }

        }
    }
}
