package Buoi4.ecb;

public class CaculatorEntity {
private double result;

CaculatorEntity(){};

 public void add(double a, double b){
this.result = a  + b;
    }
 public void sub(double a, double b){
this.result = a  - b;
    }
 public void mu(double a, double b){
this.result  = a  * b;
    }
 public void div(double a, double b){
this.result = a  / b;
    }
 
    public double getResult(){
        return result;
    }

}
