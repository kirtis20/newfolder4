namespace C_PRAC
{
    class A
    {
        //virtual=allowed to be overwritten in a subclass
        public virtual void display()
        {
            Console.WriteLine("in A");
        }
    }
    class B : A
    {
        public override void display()
        {
            Console.WriteLine("in B");
        }

    }
    class C : B
    {
        public override void display()
        {
            Console.WriteLine("in C");
        }
    }
    class D : C
    {
        //new=new method, not overwriting the previous method
        public new virtual void display()
        {
            Console.WriteLine("in D");
        }
    }

    class E : D
    {
        public override void display()
        {
            Console.WriteLine("in E");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new D();
            a.display();
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
