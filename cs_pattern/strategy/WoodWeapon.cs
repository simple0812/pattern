using System;
public class WoodWeapon : IWeapon {
    public void Attact(Monster monster) {
        if(!monster.IsDead())
            monster.SubHP(20);
    }
}