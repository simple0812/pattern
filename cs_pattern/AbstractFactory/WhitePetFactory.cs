 public class WhitePetFactory : IFactory {
    public IPet CreateCat() {
        return new WhiteCat();
    }

    public IPet CreateDog() {
        return new WhiteDog();
    }
 }