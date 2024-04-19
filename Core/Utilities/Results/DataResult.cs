namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(bool success, string message, T data) : base(success, message)
        {

        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
