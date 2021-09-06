using System;

namespace dp_dotnet {
    class Program {
        static void AdaptorDemo() {
            InterfaceB adaptor = new AdaptorB(new ImplA());
            Console.WriteLine(adaptor.MethodB());
        }
        static void DecoratorDemo() {
            SpanNode span = new SpanNode("hellow world!");
            ITextNode span1 = new BoldDecorator(new UnderLineDecorator(span));
            ITextNode span2 = new UnderLineDecorator(new BoldDecorator(span));
            Console.WriteLine(span1.getText());
            Console.WriteLine(span2.getText());
            span1.setText("change");
            Console.WriteLine(span1.getText());
            Console.WriteLine(span2.getText());

        }
        static void Main(string[] args) {
            Console.WriteLine("Call AdaptorDemo");
            AdaptorDemo();
            Console.WriteLine("Call DecoratorDemo");
            DecoratorDemo();
        }
    }
}
