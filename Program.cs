using System;

namespace dp_dotnet {
    class Program {
        static void AdaptorDemo() {
            InterfaceB adaptor = new AdaptorB(new ImplA());
            Console.WriteLine(adaptor.MethodB());
        }
        static void Main(string[] args) {
            Console.WriteLine("Call AdaptorDemo");
            AdaptorDemo();
        }
    }
}
