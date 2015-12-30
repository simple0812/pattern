interface IProtectedProxy  
{  
    void Request();  
}

using System;  
  
class ProtectedProxy : IProtectedProxy  
{  
    private string _Name;  
    private IProtectedProxy _ProtectedTruthInstance;  
    public ProtectedProxy(string name)  
    {  
        _Name = name;  
        _ProtectedTruthInstance = new ProtectedTruthInstance();  
    }  
 
    #region IProtectedProxy 成员  
  
    public void Request()  
    {  
        if (_Name == "GhostBear")  
        {  
            _ProtectedTruthInstance.Request();  
        }  
        else  
        {  
            Console.WriteLine("you promision to access this method.");  
        }  
    }  
 
    #endregion  
} 

using System;  
  
class ProtectedTruthInstance : IProtectedProxy  
{  
    public ProtectedTruthInstance() { }  
    #region IProtectedProxy 成员  
  
    public void Request()  
    {  
        Console.WriteLine("you admision to access this method.");  
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
             
            ProtectedProxy pp = new ProtectedProxy("Jim");  
            pp.Request();  
            Console.ReadKey();  
        }  
    }  
}  