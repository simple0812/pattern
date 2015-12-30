interface IRemoteRequest  
{  
    void RemoteRequest();  
}  


using System;  
class RemoteProxy:IRemoteRequest  
{  
    private IRemoteRequest _RemoteInstance;  
    public RemoteProxy(IRemoteRequest remoteinstance)  
    {  
        _RemoteInstance = remoteinstance;  
    }  
 
    #region IRemoteRequest 成员  
  
    public void RemoteRequest()  
    {  
        _RemoteInstance.RemoteRequest();  
    }  
 
    #endregion  
}  


using System;  
class RemoteInstance : IRemoteRequest  
{  
    private string _Name;  
    public RemoteInstance(string name)  
    {  
        _Name = name;  
    }  
 
    #region IRemoteRequest 成员  
  
    public void RemoteRequest()  
    {  
        Console.WriteLine("You current request Instance is " + _Name + " and it's " + DateTime.Now + " now ");  
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
            RemoteInstance ri = new RemoteInstance("cemare");  
            RemoteProxy rp = new RemoteProxy(ri);  
            rp.RemoteRequest();  
  
  
            Console.ReadKey();  
        }  
    }  
}