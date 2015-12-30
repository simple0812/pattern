public class Director {
    public Builder Create(Builder builder) {
        builder.BuildDoor();
        builder.BuildWheel();
        builder.BuildWindow();

        return builder;
    }
}