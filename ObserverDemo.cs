using System;
using System.Collections.Generic;

namespace dp_dotnet {

    public interface IObserver {
        void OnEvent(string e);
    }
    public class Seller : IObserver {
        public void OnEvent(string e) {
            Console.WriteLine("Seller get event " + e);
        }
    }
    public class Manager : IObserver {
        public void OnEvent(string e) {
            Console.WriteLine("Manager get event " + e);
        }
    }

    public class Store {
        private List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer) {
            observers.Add(observer);
        }

        public void Sell(string something) {
            foreach (var observer in observers) {
                observer.OnEvent("sell " + something);
            }
        }
    }
}