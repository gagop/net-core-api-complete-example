namespace Web.Api.Core.Interfaces
{
    public abstract class UseCaseResponseMessage
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        protected UseCaseResponseMessage(bool success = false,
            string message = null)
        {
            Success = success;
            Message = message;
        }
    }
}
