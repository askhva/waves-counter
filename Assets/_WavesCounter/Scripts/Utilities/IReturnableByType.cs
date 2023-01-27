namespace _WavesCounter.Scripts.Utilities
{
    public interface IReturnableByType<in TK>
    {
        public T GetItem<T>() where T : TK;
    }
}