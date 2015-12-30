using System;

public class Monster {
    public string Name {get; set;}
    public int HP {get;set;}

    public bool IsDead() {
        return HP <= 0;
    } 

    public void SubHP(int hp) {
        if(this.HP <= 0) {
            Console.WriteLine(Name + "已经死亡");
        }
        this.HP -= hp;
        Console.WriteLine(Name + "损失生命" + hp + "HP" + this.HP);
        if(this.HP <= 0) {
            this.HP = 0;
            Console.WriteLine(Name + "死亡");
        }
    }
}