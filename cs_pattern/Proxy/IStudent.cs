public interface IStudent {
    string Name {get;set;}
    void SayHello();
    void SendFlower(IStudent s);
}