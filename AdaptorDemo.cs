namespace dp_dotnet {
    public interface InterfaceA {
        string MethodA();
    }
    
    public interface InterfaceB {
        string MethodB();
    }

    public class ImplA : InterfaceA {
        public string MethodA() {
            return "Call A";
        }
    }

    public class AdaptorB : InterfaceB {
        InterfaceA objA;  // 适配器保存了interface A一个引用
        public AdaptorB(InterfaceA a) {
            this.objA = a;
        }
        // 通过内部的interface A的引用，将MethodA的调用转为MethodB
        public string MethodB() {
            return objA.MethodA();
        }
    }
}