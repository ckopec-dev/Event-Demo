
namespace EventDemo
{
    internal class MyClass
    {
        public event EventHandler<CustomEventArgs>? SomethingCompleted;

        public void DoSomething()
        {
            OnSomethingCompleted(new CustomEventArgs(true, DateTime.Now));
        }

        protected virtual void OnSomethingCompleted(CustomEventArgs e)
        {
            SomethingCompleted?.Invoke(this, e);
        }
    }
}
