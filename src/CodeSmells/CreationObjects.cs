namespace CodeSmells
{
    public static class CreationObjects
    {
        public static Foo CreateNewFoo()
        {
            var foo = new Foo() { Code = 1 };
            return foo;
        }
    }
    
    public class Foo 
    {
        public int Code { get; set; }
    }
}