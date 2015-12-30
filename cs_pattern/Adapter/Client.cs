using System;

public class Client {

    static void Main() {
        Adaptee adaptee = new Adaptee();
        ISpec spec = new Adapter(adaptee);
        spec.SpecMethod();

    }
}