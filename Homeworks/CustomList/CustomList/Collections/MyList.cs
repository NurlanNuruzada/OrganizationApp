using System.Collections;
using System.ComponentModel;

namespace CustomList.Collections;

public sealed class MyList<T>:IEnumerable<T>
{
    public int Count { get; private set; }
    private int _capacity;
    public int Capacity 
    {
        get => _capacity;
        set
        {
            if (value < Count)
            {
                throw new ArgumentOutOfRangeException("capacity was less than the current size.");
            }
            _capacity = value;
            Array.Resize(ref array, _capacity);
        }
    }
    private T[] array;
    public MyList()
    {
        Count = 0;
        _capacity = 0;
        array = new T[_capacity];
    }
    public T this[int index] { 
        get
        {
            if (index >= Count) 
            { 
                throw new ArgumentOutOfRangeException(); 
            }
            return array[index];
        } 
        set
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            array[index] = value;
        } 
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T obj)
    {
        if (_capacity == 0)
        {
            _capacity = 4;
            Array.Resize(ref array, _capacity);
        }
        if (_capacity == Count)
        {
            _capacity *= 2;
            Array.Resize(ref array, _capacity);
        }
        array[Count]=obj;
        Count++;
    }
    public bool Contains(T obj)
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj.Equals(array[i]))
            {
                return true;
            }
        }
        return false;
    }

    public T? Find(Predicate<T> predicate)
    {
        for (int i = 0; i < Count; i++)
        {
            if (predicate(array[i]))
            {
                return array[i];
            }
        }
        return default;
    }
    public void AddRange(IEnumerable<T> collection)
    {
        int requiredCapacity = Count + collection.Count();
        if (requiredCapacity > _capacity)
        {
            int newCapacity = _capacity;
            while (newCapacity < requiredCapacity)
            {
                newCapacity *= 2;
            }
            T[] newArray = new T[newCapacity];
            Array.Copy(array, newArray, Count);
            array = newArray;
            _capacity = newCapacity;
        }

        foreach (T item in collection)
        {
            array[Count++] = item;
        }
    }
    public void Clear()
    {
        Array.Clear(array, 0, Count);
        Count = 0;
    }
    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Equals(array[i], item))
            {
                return i;
            }
        }
        return -1;
    }
    public bool Remove(T item)
    {
        int index = -1;

        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], item))
            {
                index = i;
                break;
            }
        }

        if (index >= 0)
        {
            for (int i = index + 1; i < Count; i++)
            {
                array[i - 1] = array[i];
            }

            Count--;
            array[Count] = default(T);

            return true;
        }

        return false;
    }
    public bool Exists(Func<T, bool> predicate)
    {
        foreach (T item in this)
        {
            if (predicate(item))
            {
                return true;
            }
        }
        return false;
    }

    public void Reverse()
    {
        Array.Reverse(array);
    }

    public void Sort(Comparison<T> comparison)
    {
        if (comparison == null)
        {
            throw new ArgumentNullException();
        }
        Array.Sort(array, 0, Count, Comparer<T>.Create(comparison));
    }
}
