namespace TheFourthProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack elements = new("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {elements.Size}, Top = '{elements.Top}'");
            Console.WriteLine($"Предыдущий элемент {elements.PreviousElement}");
            var deleted = elements.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = '{elements.Size}'");
            elements.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {elements.Size}, Top = '{elements.Top}'");
            elements.Pop();
            elements.Pop();
            elements.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {elements.Size}, Top = {(elements.Top == null ? "null" : elements.Top)}");
            elements.Pop();
            var s = MyStack.Concat(new MyStack("a", "b", "c"), new MyStack("1", "2", "3"), new MyStack("A", "B", "C"));
        }
    }
}