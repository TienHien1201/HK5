package Buoi4;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class CaculatorView extends JFrame implements ActionListener {
    private JPanel jPanelRemote;
    private JLabel jLabelInputRemote1, jLabelInputRemote2, jLabelOutputRemote;
    private JTextField jTextFieldInputRemote1,jTextFieldInputRemote2;
    private JButton addButton, suButton, divButton,muButton;
    private CaculatorModel caculatorModelRemote;
    CaculatorView(){
    buildPanel();

setSize( 400, 400);
setVisible(true);
setLocationRelativeTo(null);
setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
add(jPanelRemote);
}

public void buildPanel(){
    jPanelRemote = new JPanel();
    // jPanelRemotel.setBackground(Color.BLUE);
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
        addButton.addActionListener(this);//calculatorWindow
        jPanelRemote.add(addButton);
        
        suButton = new JButton("sub");
        suButton.addActionListener(this);//calculatorWindow
        jPanelRemote.add(suButton);

        muButton = new JButton("mu");
        muButton.addActionListener(this);//calculatorWindow
        jPanelRemote.add(muButton);

        divButton = new JButton("div");
        divButton.addActionListener(this);//calculatorWindow
        jPanelRemote.add(divButton);


}

//Xử lí sự kiện
@Override
public void actionPerformed(ActionEvent e) {
caculatorModelRemote = new CaculatorModel(); 

    // TODO Auto-generated method stub
    String comand = e.getActionCommand();
     //lấy data từ input1
     double num1 = Double.
     parseDouble(jTextFieldInputRemote1.getText());
     
     double num2 = Double.
     parseDouble(jTextFieldInputRemote2.getText());
     
     if(comand.equals("ADD")){
        caculatorModelRemote.add(num1, num2);
        double sum = caculatorModelRemote.getResult();
    jLabelOutputRemote.setText("" + sum); 
        }
        if(comand.equals("sub")){
        caculatorModelRemote.sub(num1, num2);
        double sum = caculatorModelRemote.getResult();
        jLabelOutputRemote.setText("" + sum); 
        }
        if(comand.equals("div")){
        caculatorModelRemote.div(num1, num2);
        double sum = caculatorModelRemote.getResult();
        jLabelOutputRemote.setText("" + sum); 
        }
        
     if(comand.equals("mu")){
      caculatorModelRemote.mu(num1, num2);
        double sum = caculatorModelRemote.getResult();
 jLabelOutputRemote.setText("" + sum); 
}
}
}
