using System;

public class Client {
    static void Main() {
        IObserver observer = new ConcreteObserver();
        Subject subject = new Subject();
        subject.Regist(observer);
        subject.Notify();
    }
}
