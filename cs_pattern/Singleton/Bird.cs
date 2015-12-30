using System;

public class Bird {
    public static readonly Bird Instance = new Bird();
    private Bird(){}

    public void Show() {
        Console.WriteLine("hello world");
    }
}