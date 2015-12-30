using System;

//为每种需要创建的对象创建一个factory
/*
    添加bird
    1.添加Bird并实现IPet
    2.添加BirdFactory并实现IFactory
*/ 

public class Client {
    static void Main() {
        IFactory catFactory = new CatFactory();
        IPet cat = catFactory.Create();
        cat.Show();
    }
}