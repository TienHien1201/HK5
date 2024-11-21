package Buoi4.ecb;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class CaculatorControl implements ActionListener {
    private CaculatorEntity caculatorEntityRemote ;
    private CaculatorBoundary caculatorBoundaryRemote ;

    CaculatorControl(){
caculatorBoundaryRemote = new CaculatorBoundary(this);
        caculatorEntityRemote = new CaculatorEntity();

    };

    //Xử lí sự kiện
    @Override
    public void actionPerformed(ActionEvent e) {
        
        // TODO Auto-generated method stub
            String comand = e.getActionCommand();
             //lấy data từ input1
             double num1 = Double.
             parseDouble(caculatorBoundaryRemote.getjTextFieldInputRemote1().getText());
             
             double num2 = Double.
             parseDouble(caculatorBoundaryRemote.getjTextFieldInputRemote2().getText());
             
             if(comand.equals("ADD")){
                caculatorEntityRemote.add(num1, num2);
                double sum = caculatorEntityRemote.getResult();
            caculatorBoundaryRemote.getjLabelOutputRemote().setText("" + sum); 
                }
                if(comand.equals("sub")){
                caculatorEntityRemote.sub(num1, num2);
                double sum = caculatorEntityRemote.getResult();
                caculatorBoundaryRemote.getjLabelOutputRemote().setText("" + sum); 
                }
                if(comand.equals("div")){
                caculatorEntityRemote.div(num1, num2);
                double sum = caculatorEntityRemote.getResult();
                caculatorBoundaryRemote.getjLabelOutputRemote().setText("" + sum); 
                }
                
             if(comand.equals("mu")){
              caculatorEntityRemote.mu(num1, num2);
                double sum = caculatorEntityRemote.getResult();
         caculatorBoundaryRemote.getjLabelOutputRemote().setText("" + sum); 
        }
       
    }

}

