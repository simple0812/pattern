public class Client {
    static void Main() {
        IStudent tom = new SchoolGirl {Name = "tome"};
        IStudent tony = new SchoolGirl {Name = "tony"};

        IStudent proxyer = new Proxy(tom);

        proxyer.SayHello();
        proxyer.SendFlower(tony);
    }
}