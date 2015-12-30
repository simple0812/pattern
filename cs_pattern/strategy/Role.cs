public class Role {
    public IWeapon Weapon {get; set;}
    public Role(IWeapon weapon) {
        this.Weapon = weapon;
    }

    public void Attact(Monster monster) {
        this.Weapon.Attact(monster);
    }
}