using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab6_MPP
{
    public class DynamicList<T> : IEnumerable<T>
    {
        private T[] data = new T[0];

        public int Count
        {
            get
            {
                return data.Length;
            }
        }

        public T[] Items
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public void Add(T indata)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = indata;
        }

        public void Remove(T del_item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Equals(del_item))
                {
                    for(int j = i; j < Count - 1; j++)
                        data[i] = data[i + 1];
                    Array.Resize(ref data, Count - 1);
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
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }
    }
}
