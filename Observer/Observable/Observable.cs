using System.Collections.Generic;
using Observer.Observer;
using Observer.Weather;

namespace Observer.Observable
{
    public abstract class Observable<T> : IObservable<T>
    {
        private List<IObserver<T>> _observers = new List<IObserver<T>>();

        public void Register(IObserver<T> observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            T data = GetChangedData();
            foreach (var observer in _observers)
            {
                observer.Update(data);
            }
        }

        public void Remove(IObserver<T> observer)
        {
            _observers.Remove(observer);
        }
        
        protected abstract T GetChangedData();
    }
}