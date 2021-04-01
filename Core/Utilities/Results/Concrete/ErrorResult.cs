using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
