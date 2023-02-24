namespace TheFourthProgram
{
    public static class StackExtensions
    {
        public static MyStack Merge(this MyStack obj1, MyStack obj2)
        {
            obj2.ElementsOfList.Reverse();
            obj1.Add(obj2.ElementsOfList);
            return obj1;
        }
    }
}
