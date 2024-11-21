 package Buoi2.depedency;

public class Main {
public static void main(String[] args) {
    B bRemote = new B();
    A aRemote = new A(bRemote);

    aRemote.print();
}
}
