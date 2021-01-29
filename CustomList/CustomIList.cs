using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomIList<T>: IList<T>
    {
        private  IList<T> list = new List<T>();

        public int Count()
        {
            return list.Count;
        
        }

        public bool IsReadOnly()
        {
            return list.IsReadOnly;
        }

        int ICollection<T>.Count => throw new NotImplementedException();

        bool ICollection<T>.IsReadOnly => throw new NotImplementedException();

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

         public bool Remove(T item)
         {
            return list.Remove(item);
         }

         public void RemoveAt(int index)
         {
         list.RemoveAt(index);
         }

         public IEnumerator<T> GetEnumerator()
         {
          return list.GetEnumerator();
         }

         IEnumerator IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }           

          public void Add(T item)
          {
             list.Add(item);
          }

          public void Clear()
          {
            list.Clear();
          }

          public bool Contains(T item)
          {
            return list.Contains(item);
          }

           public void CopyTo(T[] array, int arrayIndex)
           {
            list.CopyTo(array, arrayIndex);
           }
    }

  }
