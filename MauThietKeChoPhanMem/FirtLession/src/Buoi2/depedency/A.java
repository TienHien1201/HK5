package Buoi2.depedency;

public class A {
private String name ;

A(){}

A(B bRemote){
 
 bRemote.printName(); 
}
public void print(){
       B bRemote = new B();
       bRemote.printName();
}
}
