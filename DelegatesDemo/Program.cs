namespace DelegatesDemo
{

    //class MyDelegate : Delegate
    //{

    //}
    // Step 1: Delegate Declaration
    delegate void MyDelegate(string str);

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            //a.RunDelete();
            // invoke
            a.MyDelegate.Invoke("Hello calling from program class");
        }


    }

    class MyClass
    {
        // instantiate
        public event MyDelegate MyDelegate = null;
        public MyClass()
        {
            // initialize
            MyDelegate = new MyDelegate(Greeting);
        }
        static void Greeting(string text)
        {
            Console.WriteLine($"Greeting: {text}");
        }

        // invoke
        public void RunDelete()
        {

            MyDelegate("hello");
        }
    }
}