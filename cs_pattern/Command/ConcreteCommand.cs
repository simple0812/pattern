public class ConcreteCommand : ICommand {
    private Receiver receiver = null;

    public ConcreteCommand(Receiver receiver) {
        this.receiver = receiver;
    }

    public void Exec() {
        this.receiver.action();
    }
}
