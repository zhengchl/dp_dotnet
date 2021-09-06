namespace dp_dotnet {
    public interface ITextNode {
        void setText(string str);
        string getText();
    }

    public class SpanNode : ITextNode {
        private string text;
        public SpanNode(string str) {
            this.text = str;
        }
        public void setText(string str) {
            this.text = str;
        }
        public string getText() {
            return "<span>" + this.text + "</span>";
        }
    }

    public abstract class NodeDecorator : ITextNode {
        protected ITextNode node;
        public NodeDecorator(ITextNode node) {
            this.node = node;
        }
        public void setText(string str) {
            this.node.setText(str);
        }
        public abstract string getText();
    }

    public class BoldDecorator : NodeDecorator {
        public BoldDecorator(ITextNode node) : base(node) {
        }
        public override string getText() {
            return "<b>" + this.node.getText() + "</b>";
        }
    }

    public class UnderLineDecorator : NodeDecorator {
        public UnderLineDecorator(ITextNode node) : base(node) {

        }
        public override string getText() {
            return "<u>" + this.node.getText() + "</u>";
        }
    }
}