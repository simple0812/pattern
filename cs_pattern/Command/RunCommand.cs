public class RunCommand : ICommand {
    private Receiver receiver = null;

    public RunCommand(Receiver receiver) {
        this.receiver = receiver;
    }

    public void Exec() {
        this.receiver.Run();
    }
}
