public class CatFactory : IFactory {
    public IPet Create() {
        return new Cat();
    }
}