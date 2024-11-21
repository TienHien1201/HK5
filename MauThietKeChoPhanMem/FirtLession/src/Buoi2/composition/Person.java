package Buoi2.composition;

public class Person {
private Head hRemote;

// V1
// Person(){  hRemote = new Head();}
// V2
 Person(){  }

 //V1
// public void control(){
//     hRemote.See();
// }

// V2
public void control(){
    hRemote = new Head();
    hRemote.See();
}
}