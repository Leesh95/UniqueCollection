using System;
using System.Collections;

namespace UniqueCollections
{
    public class UniqueCollection<T> : ICollection<T>
    {
        public bool IsReadOnly
        {
            get { return false; }
        }
        //
        public List<T> names = new List<T>();
        public int Count => names.Count;
        //
        public void Add(T name)
        {
            if (!names.Contains(name))
                names.Add(name);
        }
        //
        public bool Contains(T name)
        {
            return names.Contains(name);
        }
        //
        public bool Remove(T name)
        {
            return names.Remove(name);
        }
        //
        public void Clear()
        {
            while (Count > 0)
                names.RemoveAt(0);
            System.Console.WriteLine("-List is Empty-");
        }
        //
        public void CopyTo(T[] array, int arrayIndex)
        {
            array = names.GetRange(arrayIndex, names.Count).ToArray();
        }
        //
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return names[i];
        }
    }
}
