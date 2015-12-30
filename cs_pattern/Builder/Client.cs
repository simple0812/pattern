using System;

/*添加ford车间
    1.添加类Ford.cs并继承Builder
*/

public class Client{
    static void Main() {
        Director director = new Director();
        Builder bmw = new Bmw();    
        Builder benz = new Benz();

        director.Create(bmw).GetResult().Show();
        director.Create(benz).GetResult().Show();
    }
}