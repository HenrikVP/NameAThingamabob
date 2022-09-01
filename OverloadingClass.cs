namespace OOP007Inheritance
{
    internal class OverloadingClass
    {
        public OverloadingClass()
        {

        }
        public OverloadingClass(string s)
        {

        }

        public void MethodOverload()
        {
            Console.WriteLine("This is overloaded method without parameters");
        }

        public void MethodOverload(string s)
        {
            Console.WriteLine("This is overloaded method with string parameter:" + s);
        }

    }
}
