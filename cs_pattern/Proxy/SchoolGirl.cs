using System;

public class SchoolGirl : IStudent {
    public string Name {get;set;}
    public void SayHello() {
        Console.WriteLine("hello");
    }

    public void SendFlower(IStudent girl) {
        Console.WriteLine(girl.Name + ", you are so beautiful");
    }
}