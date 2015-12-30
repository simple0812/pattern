using System.Collections.Generic;
using System.Collections;
public class Subject {
    public IList<IObserver> list = new List<IObserver>();
    public void Regist(IObserver observer) {
        list.Add(observer);
    }

    public void Notify() {
        foreach(var each in list) {
            if(null != each) each.Update();
        } 
    }
}
