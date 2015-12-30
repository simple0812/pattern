using System;
/*
    添加bird类
    1.添加抽象类bird并实现IPet接口
    2.添加具体类WhiteBird和BlackBird
    3.添加BirdFactory并实现IFactory
*/
public class Client {
    static void Main() {
        IPet whiteDog = new WhitePetFactory().CreateDog();
        whiteDog.Show();
    }
}