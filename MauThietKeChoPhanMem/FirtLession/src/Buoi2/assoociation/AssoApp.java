package Buoi2.assoociation;

public class AssoApp {

    public static void main(String[] args) {

        B bRemote = new B();
        // V1
        // A aRemote = new A(bRemote);
        // V2
        //main() message to A
        A aRemote = new A();
        aRemote.setBRemote(bRemote);
        aRemote.print();

        
    }

}