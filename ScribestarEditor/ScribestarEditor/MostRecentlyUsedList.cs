using System.Collections.Generic;
using System.Linq;

namespace ScribestarEditor
{
    public class MostRecentlyUsedList 
    {
        private readonly int maxSize;
        private Stack<int> accessorList;

        public MostRecentlyUsedList(int maxSize)
        {
            this.maxSize = maxSize;
            IsEmpty = true;
            accessorList = new Stack<int>();
        }

        public bool IsEmpty { get; private set; }
        public int Size => accessorList.Count;
        public IEnumerable<int> Accessor => accessorList;

        public void AddOne(int i) 
        {
            IsEmpty = false;
            if (Size == maxSize)
            {
                var existingItems = Accessor;
                var newItems = existingItems.TakeWhile((item, index) => index < maxSize - 1);
                accessorList = new Stack<int>(newItems);

            }
            accessorList.Push(i);
            
        }
    }
}