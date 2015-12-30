public class DogFactory : IFactory {
    public IPet Create() {
        return new Dog();
    }
}