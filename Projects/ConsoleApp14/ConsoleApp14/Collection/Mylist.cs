using System.Collections;

namespace ConsoleApp14.Collection;
public class Mylist<T>:IEnumerable<T>
{
    public int Count { get; set; }
    public int _capasity;
    public int Capacity 
    {
        get 
        {
            return _capasity;
        }
         set 
        {
            if (value < Count) 
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    private T[] array;
    public T this[int index]
    {
        get 
        { 
            if (index>=Count)
            {
                throw new IndexOutOfRangeException(); 
            }
            return array[index];
        }
        set 
        {
            if (index>=Count)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = value;
        }
    }
    public Mylist()
    {
        Count = 0;
        Capacity= 0;
        array = new T[_capasity];
    }
    public void Add(T obj)
    {
        if (_capasity== 0)
        {
            _capasity= 4;
            Array.Resize(ref array, _capasity);
        }
        if (_capasity == Count) 
        {
            _capasity *= 2;
            Array.Resize(ref array, _capasity);
        }
        array[Count] = obj;
        Count++;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0;i< Count; i++)
        {
            yield return array[i];
        }
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public bool Contains(T obj)
    {
        for(int i = 0;i<Count;i++)
        {
            if (array.Contains(obj) )
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
            if ((predicate(array[i])))
            {
                return array[i];
            }
        }
        return default;
    }


}
