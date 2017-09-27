using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab6_MPP
{
    public class DynamicList<T> : IEnumerable<T>
    {

        private T[] data = new T[0];
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T indata)
        {
            const
                byte MEMORY_CONTROL = 10;

            if (data.Length == count)
                Array.Resize(ref data, data.Length + MEMORY_CONTROL);
            data[count] = indata;
            count++;
        }

        public void Remove(T del_item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Equals(del_item))
                {
                    for (int j = i; j < Count - 1; j++)
                        data[i] = data[i + 1];
                    Array.Resize(ref data, Count - 1);
                    count--;
                    return;
                }
            }
            throw new ArgumentException("Объект в DynamicList<T> не найден.");
        }

        public void RemoveAt(int i)
        {
            if (i <= Count)
                Remove(data[i]);
            else
                throw new IndexOutOfRangeException();
        }

        public void Clear()
        {
            data = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index > count)
                    throw new ArgumentOutOfRangeException();
                else
                    return data[index];
            }
            set
            {
                if (index > count)
                    throw new ArgumentOutOfRangeException();
                else
                    data[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return data[i];
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return data[i];
        }
    }
}
