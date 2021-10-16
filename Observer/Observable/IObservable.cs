using Observer.Observer;

namespace Observer.Observable
{
    public interface IObservable<T>
    {
        public void Register( IObserver<T> observer );
        
        public void Notify();
        
        public void Remove( IObserver<T> observer );
    }
}