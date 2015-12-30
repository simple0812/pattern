using System;
public class MagicWeapon : IWeapon {
    public void Attact(Monster monster) {
        if(!monster.IsDead())
            monster.SubHP(new Random().NextDouble() < 0.5 ? 100 : 200);
    }
}