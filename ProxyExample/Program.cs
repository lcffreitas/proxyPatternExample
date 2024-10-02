using ProxyExample;

Client client = new Client();

Console.WriteLine("Cliente: Usando o Proxy.");
Proxy proxy = new Proxy();
client.ClientCode(proxy);

Console.WriteLine("\nCliente: Usando o RealSubject diretamente.");
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);