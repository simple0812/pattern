public class Benz : Builder {
    private Car car = new Car("benz");

    public override void BuildDoor() {
        car.Door = "4个门";
    }

    public override void BuildWheel() {
        car.Wheel = "8个轮子";
    }

    public override void BuildWindow() {
        car.Window = "12个窗";
    }

    public override Car GetResult() {
        return car;
    }
}