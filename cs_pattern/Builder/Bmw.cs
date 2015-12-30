public class Bmw : Builder {
    private Car car = new Car("bmw");

    public override void BuildDoor() {
        car.Door = "2个门";
    }

    public override void BuildWheel() {
        car.Wheel = "6个轮子";
    }

    public override void BuildWindow() {
        car.Window = "4个窗";
    }

    public override Car GetResult() {
        return car;
    }
}