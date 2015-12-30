public class Client {

    static void Main() {
        var monster1 = new Monster{Name = "monster1", HP = 100};
        var monster2 = new Monster{Name = "monster2", HP = 200};
        var monster3 = new Monster{Name = "monster3", HP = 300};

        var woodWeapon = new WoodWeapon();
        var ironWeapon = new IronWeapon();
        var magicWeapon = new MagicWeapon();

        var role = new Role(woodWeapon);

        role.Attact(monster1);
        role.Attact(monster1);
        role.Attact(monster1);
        role.Attact(monster1);
        role.Attact(monster1);
        role.Attact(monster1);
        role.Attact(monster1);
        role.Attact(monster1);

    }
}