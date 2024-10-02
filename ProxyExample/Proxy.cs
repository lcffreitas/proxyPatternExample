using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        public void Request()
        {
            if(_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            Console.WriteLine("Proxy: Verificando o acesso antes de delegar ao RealSubject.");
            _realSubject.Request();
        }
    }
}
