using System;

public class Client{
    static void Main() {
        Receiver receiver = new Receiver();
        ICommand command  = new ConcreteCommand(receiver);
        ICommand runCmd = new RunCommand(receiver);
        ICommand sitCmd = new SitCommand(receiver);

        Invoker invoker = new Invoker();
        invoker.SetCommand(command);
        invoker.Invoke();
        
        invoker.SetCommand(runCmd);
        invoker.Invoke();
    
        invoker.SetCommand(sitCmd);
        invoker.Invoke();
    }
}
