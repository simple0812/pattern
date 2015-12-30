using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Person {
    public string Name {get;set;}
}

[Serializable]
public class Cat :ICloneable {
    public string Name{get;set;}
    public Person Master {get;set;}

    public object Clone() {
        return this.MemberwiseClone();
    }

    public object DeepClone() {
        object obj = null;

        using(MemoryStream ms = new MemoryStream()) {

            BinaryFormatter bf = new BinaryFormatter();   

            bf.Serialize(ms, this);       
            ms.Seek(0, 0);  

            obj = bf.Deserialize(ms);   
        }       

        return obj; 
    }
}