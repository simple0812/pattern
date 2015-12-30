using System;
public class IronWeapon : IWeapon {
    public void Attact(Monster monster) {
        if(!monster.IsDead())
            monster.SubHP(50);
    }
}