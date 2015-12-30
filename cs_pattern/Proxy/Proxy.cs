public class Proxy : IStudent {
    public string Name {get;set;}
    public IStudent Delegater {get;set;}
    public Proxy (IStudent student) {
        this.Delegater = student; 
    }

    public void SayHello() {
        Delegater.SayHello();
    }

    public void SendFlower(IStudent student) {
        Delegater.SendFlower(student);
    }
}