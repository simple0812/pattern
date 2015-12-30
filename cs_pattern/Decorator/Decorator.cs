using System;

public class Decorator : IComponent {
    private IComponent component = null;

    public Decorator(IComponent component) {
        this.component = component;
    }

    public void Do() {
        component.Do();
        Console.WriteLine("decorator");
    }
}
