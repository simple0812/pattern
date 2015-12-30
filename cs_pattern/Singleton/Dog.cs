using System;

public class Dog {
    private static readonly Dog _instance = new Dog();

    private Dog() {
    }

    public static Dog Instance {
        get { return _instance; }
    }

    public void Show() {
        Console.WriteLine("hello world");
    }
}