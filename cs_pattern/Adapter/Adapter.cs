public class Adapter : ISpec {
    private Adaptee adaptee = null;
    public Adapter(Adaptee adaptee) {
        this.adaptee = adaptee;
    }
    public void SpecMethod() {
        this.adaptee.OtherMethod();
    }
}