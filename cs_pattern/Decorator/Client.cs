using System;

public class Client {
    static void Main() {
        IComponent component = new ConcreteComponent();
        IComponent decorator = new Decorator(component);
        var p = new Decorator(decorator);
        p.Do();
    }
}
