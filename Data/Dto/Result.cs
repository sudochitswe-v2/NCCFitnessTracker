

namespace FitnessTracker.Desktop.Data.Dto
{
    public class Result<T>
    {
        public Result() { }

        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
