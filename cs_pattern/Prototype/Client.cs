using System;

public class Client {
    static void Main() {
        var p1 = new Person{Name = "zl"};
        var p2 = new Person{Name = "zw"};

        var cat = new Cat {Name = "tom", Master = p1};
        
        var cat1 = (Cat)cat.Clone();
        var cat2 = (Cat)cat.DeepClone();

        cat.Name = "xx";
        cat.Master.Name = "zk";

        Console.WriteLine(cat1.Name);
        Console.WriteLine(cat1.Master.Name);

        Console.WriteLine(cat2.Name);
        Console.WriteLine(cat2.Master.Name);
    }
}