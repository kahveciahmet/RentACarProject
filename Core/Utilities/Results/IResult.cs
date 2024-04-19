namespace Core.Utilities
{
    public interface IResult
    {
        public bool IsSuccess { get; }
        public string Message { get; set; }
    }
}
