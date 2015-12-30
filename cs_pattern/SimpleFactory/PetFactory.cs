public class PetFactory {
    public static IPet Create(string flag) {
        IPet pet = null;

        switch(flag) {
            case "cat" : 
                pet = new Cat();
                break;

            case "dog" : 
                pet = new Dog();
                break;

            default : 
                pet = new Cat();
                break;
        }

        return pet;
    }
}