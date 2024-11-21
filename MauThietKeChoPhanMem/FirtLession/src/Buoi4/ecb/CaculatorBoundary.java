package Buoi4.ecb;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class CaculatorBoundary extends JFrame  {
    
    private JPanel jPanelRemote;
    
    private JLabel jLabelInputRemote1, jLabelInputRemote2, jLabelOutputRemote;
    private JTextField jTextFieldInputRemote1,jTextFieldInputRemote2;
    private JButton addButton, suButton, divButton,muButton;
private CaculatorControl caculatorControlRemote;

    CaculatorBoundary(CaculatorControl caculatorControlRemote){
        this.caculatorControlRemote = caculatorControlRemote;
        buildPanel();
        
        }

        public void buildPanel(){
            
            jPanelRemote = new JPanel();
    // jPanelRemote.setBackground(Color.BLUE);
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
        addButton.addActionListener(caculatorControlRemote);//calculatorWindow
        jPanelRemote.add(addButton);
        
        suButton = new JButton("sub");
        suButton.addActionListener(caculatorControlRemote);//calculatorWindow
        jPanelRemote.add(suButton);
        
        muButton = new JButton("mu");
        muButton.addActionListener(caculatorControlRemote);//calculatorWindow
        jPanelRemote.add(muButton);
        
        divButton = new JButton("div");
        divButton.addActionListener(caculatorControlRemote);//calculatorWindow
        jPanelRemote.add(divButton);
        setSize( 400, 400);
        setVisible(true);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        add(jPanelRemote);
        
        }
        
public JPanel getjPanelRemote() {
    return jPanelRemote;
}

public JLabel getjLabelInputRemote1() {
    return jLabelInputRemote1;
}

public JLabel getjLabelInputRemote2() {
    return jLabelInputRemote2;
}

public JLabel getjLabelOutputRemote() {
    return jLabelOutputRemote;
}

public JTextField getjTextFieldInputRemote1() {
    return jTextFieldInputRemote1;
}

public JTextField getjTextFieldInputRemote2() {
    return jTextFieldInputRemote2;
}

public JButton getAddButton() {
    return addButton;
}

public JButton getSuButton() {
    return suButton;
}

public JButton getDivButton() {
    return divButton;
}

public JButton getMuButton() {
    return muButton;
}

public CaculatorControl getCaculatorControlRemote() {
    return caculatorControlRemote;
}

public void setjPanelRemote(JPanel jPanelRemote) {
    this.jPanelRemote = jPanelRemote;
}

public void setjLabelInputRemote1(JLabel jLabelInputRemote1) {
    this.jLabelInputRemote1 = jLabelInputRemote1;
}

public void setjLabelInputRemote2(JLabel jLabelInputRemote2) {
    this.jLabelInputRemote2 = jLabelInputRemote2;
}

public void setjLabelOutputRemote(JLabel jLabelOutputRemote) {
    this.jLabelOutputRemote = jLabelOutputRemote;
}

public void setjTextFieldInputRemote1(JTextField jTextFieldInputRemote1) {
    this.jTextFieldInputRemote1 = jTextFieldInputRemote1;
}

public void setjTextFieldInputRemote2(JTextField jTextFieldInputRemote2) {
    this.jTextFieldInputRemote2 = jTextFieldInputRemote2;
}

public void setAddButton(JButton addButton) {
    this.addButton = addButton;
}

public void setSuButton(JButton suButton) {
    this.suButton = suButton;
}

public void setDivButton(JButton divButton) {
    this.divButton = divButton;
}

public void setMuButton(JButton muButton) {
    this.muButton = muButton;
}

public void setCaculatorControlRemote(CaculatorControl caculatorControlRemote) {
    this.caculatorControlRemote = caculatorControlRemote;
}


}
