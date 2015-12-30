public class BlackPetFactory : IFactory {
    public IPet CreateCat() {
        return new BlackCat();
    }

    public IPet CreateDog() {
        return new BlackDog();
    }
 }