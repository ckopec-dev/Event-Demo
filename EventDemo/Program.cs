
namespace EventDemo
{
    class Program
    {
        static void Main()
        {
            // Object example
            MyClass myClass = new();
            myClass.SomethingCompleted += MyClass_SomethingCompleted;
            myClass.DoSomething();

            // Static example
            MyStaticClass.SomethingStaticCompleted += MyStaticClass_SomethingStaticCompleted;
            MyStaticClass.DoSomething();
        }

        private static void MyClass_SomethingCompleted(object? sender, CustomEventArgs e)
        {
            Console.WriteLine("Object example. Success: {0}, Completed at: {1}", e.IsSuccessful, e.CompletionTime);
        }

        private static void MyStaticClass_SomethingStaticCompleted(object? sender, CustomEventArgs e)
        {
            Console.WriteLine("Static example. Success: {0}, Completed at: {1}", e.IsSuccessful, e.CompletionTime);
        }
    }
}
