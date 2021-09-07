using System;
using System.Collections.Generic;

namespace dp_dotnet {
    public class Request {
        private string _name;
        private decimal _amount;

        public string Name {
            get => _name;
            set => _name = value;
        }

        public decimal Amount {
            get => _amount;
            set => _amount = value;
        }

        public Request(string name, decimal amount) {
            this._name = name;
            this._amount = amount;
        }
    }

    public interface IRequestHandler {
        bool? Process(Request req);
    }

    public class ManagerHandler : IRequestHandler {
        private const decimal _threshold = 100m;
        public bool? Process(Request req) {
            if (req.Amount > _threshold) {
                return null;
            }
            if (req.Name == "Bob") {
                return false;
            }
            return true;
        }
    }

    public class HandlerChain {
        private List<IRequestHandler> handerList = new List<IRequestHandler>();
        
        public void Add(IRequestHandler handler) {
            handerList.Add(handler);
        }

        public void Process(Request req) {
            foreach (var handler in handerList) {
                bool? rtn = handler.Process(req);
                if (rtn != null) {
                    Console.WriteLine(rtn == true? "Accepted" : "Denied" + " by " + nameof(handler));
                    return;
                }
            }
            Console.WriteLine("Process Fail!");
        }
    }
}