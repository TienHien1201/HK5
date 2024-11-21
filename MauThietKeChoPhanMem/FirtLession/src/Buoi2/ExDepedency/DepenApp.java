package Buoi2.ExDepedency;

public class DepenApp {
public static void main(String[] args) {
    Cat catRemote = new Cat();
    Animal animal = new Animal(catRemote);
    animal.Print();
}
}
