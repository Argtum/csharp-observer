namespace Observer.Observer
{
    public interface IObserver<T>
    {
        public void Update(T data);
    }
}