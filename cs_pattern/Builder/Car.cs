using System;

public class Car {
    public string Name {get;set;}
    public string Door {get;set;}
    public string Wheel {get;set;}
    public string Window {get;set;}

    public Car(string Name) {
        this.Name = Name;
    }

    public void Show() {
        Console.WriteLine(Name + " has:" + Door + Wheel + Window);
    }
}