namespace Core.Utilities
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(string message,T data):base(true,message,default)
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
