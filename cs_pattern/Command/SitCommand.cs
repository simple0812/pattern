public class SitCommand :ICommand {
    private Receiver receiver = null;

    public SitCommand(Receiver receiver) {
        this.receiver = receiver;
    }

    public void Exec() {
        this.receiver.Sit();
    }
}
