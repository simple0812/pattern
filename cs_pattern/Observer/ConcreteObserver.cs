using System;
public class ConcreteObserver : IObserver {
    public void Update() {
        Console.WriteLine("Concrete");
    }
}
