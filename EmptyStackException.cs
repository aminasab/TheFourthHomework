namespace TheFourthProgram
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Стек пустой") { }
        public EmptyStackException(string message) : base(message) { }
    }
}
