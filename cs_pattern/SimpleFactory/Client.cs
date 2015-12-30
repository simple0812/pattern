/*
添加Bird
1.添加Bird类并实现IPet
2.修改PetFactory.Create 方法 添加 case "bird" 分支
*/

public class Client {
    static void Main() {
        IPet cat = PetFactory.Create("cat");
        cat.Show();
    }
}