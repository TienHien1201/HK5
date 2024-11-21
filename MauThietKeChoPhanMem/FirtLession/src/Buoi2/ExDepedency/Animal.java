package Buoi2.ExDepedency;

public class Animal {
private String kind;

Animal(){};
Animal(Cat catRemote){
catRemote.PrintAct();

};
public void Print(){
    Cat catRemote = new Cat();
    catRemote.PrintAct();
}
}
