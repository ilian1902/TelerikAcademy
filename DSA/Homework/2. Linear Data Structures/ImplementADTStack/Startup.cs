namespace ImplementADTStack
{
    using Interfaces;
    using DataStructures;

    public class Startup
    {
        public static void Main()
        {
            TestAbstractStack();
        }

        private static void TestAbstractStack()
        {
            IAbstractStack<int> abstractStack = new AbstractStack<int>();

            // Should return true
            var isEmpty = abstractStack.IsEmpty();

            abstractStack.Push(1);
            abstractStack.Push(2);
            abstractStack.Push(3);
            abstractStack.Push(4);
            // Should have 4 elements

            // Should remove first element/last added element - (4)
            var removedElement = abstractStack.Pop();

            // Should return first element/last added element - (3)
            var firstElement = abstractStack.Peek();

            // Should return 3
            var count = abstractStack.Count;

            // Should return false
            isEmpty = abstractStack.IsEmpty();
        }
    }
}
