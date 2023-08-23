
namespace EventDemo
{
    internal class CustomEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }

        public CustomEventArgs()
        {
        }

        public CustomEventArgs(bool isSuccessful, DateTime completionTime)
        {
            IsSuccessful = isSuccessful;
            CompletionTime = completionTime;
        }
    }
}
