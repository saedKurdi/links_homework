namespace LinksHomework
{
    internal class Program
    {
        
        public delegate void Func(ref string name);


        static void Main(string[] args)
        {

            Console.WriteLine("Enter string : ");
            var str = Console.ReadLine();
            MyClass cls = new MyClass(ref str!); 

            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str);
             

        }
    }
}