using System;

namespace Generics
{
    //Non Generic list
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    //Generic Dictionary
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
        }
    }

    //Generic list
    public class GenericList<T>
    {
        public void Add(T value)
        {
            
        }

        public T this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }
}