namespace Core.Utilities
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(true,message,default)
        {
            
        }

        public SuccessDataResult(T data):base(data,true)
        {
            
        }

        public SuccessDataResult(string message):base(true,message,default)
        {
            
        }

        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
