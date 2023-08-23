
namespace EventDemo
{
    internal static class MyStaticClass
    {
        public static event EventHandler<CustomEventArgs>? SomethingStaticCompleted;
        
        public static void DoSomething()
        {
            OnSomethingStaticCompleted(new CustomEventArgs(true, DateTime.Now));
        }

        static void OnSomethingStaticCompleted(CustomEventArgs e)
        {
            SomethingStaticCompleted?.Invoke(null, e);
        }
    }
}
