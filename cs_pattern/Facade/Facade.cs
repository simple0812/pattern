public class Facade {
    private Computer computer ;
    private Screen screen ;
    private SoundBox soundBox ;

    public Facade () {
        computer = new Computer();
        screen = new Screen();
        soundBox = new SoundBox();
    }
    public void Open() {
        computer.Open();
        screen.Open();
        soundBox.Open();
    }
    
    public void Close() {
        computer.Close();
        screen.Close();
        soundBox.Close();
    }
}