namespace OOP007Inheritance
{
    public abstract class BaseInheritance
    {
        public int MyBaseProperty { get; set; }

        // For at overskrive vores basemethod skal vi gøre den virtual
        public virtual void MyBaseMethod()
        {
            Console.WriteLine("This is my base method");
        }
    }
}
