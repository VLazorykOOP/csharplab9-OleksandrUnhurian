using System;
using System.Collections;

class NumberCollection : IEnumerable, ICloneable, IComparable
{
    private ArrayList numbers = new ArrayList();

    public void Add(int value)
    {
        numbers.Add(value);
    }

    public void Reverse()
    {
        numbers.Reverse();
    }

    public object Clone()
    {
        NumberCollection copy = new NumberCollection();
        foreach (int n in numbers)
            copy.Add(n);
        return copy;
    }

    public int CompareTo(object obj)
    {
        NumberCollection other = obj as NumberCollection;
        if (other == null) throw new ArgumentException();

        return this.numbers.Count.CompareTo(other.numbers.Count);
    }

    public IEnumerator GetEnumerator()
    {
        return numbers.GetEnumerator();
    }
}