namespace TheFourthProgram
{
    public class StackItem
    {
        protected List<string> elementsOfList = new List<string>();
        protected string? top;

        public List<string> ElementsOfList
        {
            get { return elementsOfList; }
            set { elementsOfList = value; }
        }
        public string PreviousElement
        {
            get { return elementsOfList[elementsOfList.Count - 2]; }
        }
        public int Size
        {
            get { return elementsOfList.Count; }
        }
        public string Top
        {
            get
            {
                if (elementsOfList.Count == 0)
                    return null;
                return elementsOfList.Last();
            }
        }
    }
}
