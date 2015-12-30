interface IVirtualProxy  
{  
    void Request();  
}  

using System;  
using System.Threading;  
  
class VirtualProxy : IVirtualProxy  
{  
    private IVirtualProxy _TruthInstance;  
    private bool flag = false;  
    public VirtualProxy() { }  
 
    #region IVirtualProxy 成员  
  
    public void Request()  
    {  
        if (_TruthInstance != null)  
            _TruthInstance.Request();  
        else  
        {  
            Console.WriteLine("this is a virtual instance,you will see the truth instance after some minutes.");  
  
            if (!flag)  
            {  
                flag = true;  
                Thread thread = new Thread(delegate()  
                {  
                    _TruthInstance = new TruthInstance("摄像头");  
                    this.Request();  
                });
                
                thread.Start();  
            }  
        }  
    }  
    #endregion  
}  

using System;  
using System.Threading;  
  
class TruthInstance : IVirtualProxy  
{  
    private string _Name;  
    public TruthInstance(string name)  
    {  
        Thread.Sleep(5000);  
        _Name = name;  
    }  
    #region IVirtualProxy 成员  
  
    public void Request()  
    {  
        Console.WriteLine("you current request instance is " + _Name);  
    }  
 
    #endregion  
}  

using System;  
using System.Collections.Generic;  
using System.Text;  
  
namespace ProxyPattern  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            VirtualProxy vp = new VirtualProxy();  
            vp.Request();  
            vp.Request();  
            vp.Request();  
            vp.Request();  
            vp.Request();  
  
            Console.ReadKey();  
        }  
    }  
}  