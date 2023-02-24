namespace TheFourthProgram
{
    public class MyStack : StackItem
    {
        public MyStack(params string[] elementsOfArray)
        {
            Add(elementsOfArray);
        }

        // Добавление элемента в лист. 
        public void Add(string element)
        {
            elementsOfList.Add(element);
        }

        public void Add(string[] elementsOfArray)
        {
            elementsOfList.AddRange(elementsOfArray);
        }

        public void Add(List<String> elements)
        {
            elementsOfList.AddRange(elements);
        }

        // Удаление элемента.
        public string Pop()
        {
            string deletedElementFromList = null;
            try
            {
                if (elementsOfList.Count != 0)
                {
                    deletedElementFromList = elementsOfList.Last();
                    elementsOfList.RemoveAt(elementsOfList.Count - 1);
                }
                else
                {
                    throw new EmptyStackException();
                }
            }
            catch (EmptyStackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return deletedElementFromList;
        }

        public static MyStack Concat(params MyStack[] elementsOfArray)
        {
            var firstElementOfArray = elementsOfArray[0];
            foreach (MyStack element in elementsOfArray)
            {
                element.elementsOfList.Reverse();
            }
            for (int i = 1; i < elementsOfArray.Length; i++)
            {
                var folowingElementsOfArray = elementsOfArray[i];
                firstElementOfArray.elementsOfList.AddRange(folowingElementsOfArray.elementsOfList);
            }
            return firstElementOfArray;
        }
    }
}
