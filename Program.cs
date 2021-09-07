using System;

namespace dp_dotnet {
    class Program {
        static void AdaptorDemo() {
            InterfaceB adaptor = new AdaptorB(new ImplA());
            Console.WriteLine(adaptor.MethodB());
        }
        static void ResponsibilityChainDemo() {
            Request req1 = new Request("Walter", 1m);
            Request req2 = new Request("Bob", 1m);
            ManagerHandler managerHandler = new ManagerHandler();
            HandlerChain chain = new HandlerChain();
            chain.Add(managerHandler);
            chain.Process(req1);
            chain.Process(req2);
        }
        static void Main(string[] args) {
            Console.WriteLine("Call AdaptorDemo");
            AdaptorDemo();
            Console.WriteLine("Call ResponsibilityChainDemo");
            ResponsibilityChainDemo();
        }
    }
}
