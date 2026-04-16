using System;
using System.Collections;

class CharCollection : IEnumerable, ICloneable
{
    private ArrayList chars = new ArrayList();

    public void Add(char c)
    {
        chars.Add(c);
    }

    public IEnumerator GetEnumerator()
    {
        return chars.GetEnumerator();
    }

    public object Clone()
    {
        CharCollection copy = new CharCollection();
        for (int i = 0; i < chars.Count; i++)
        {
            char c = (char)chars[i];
            copy.Add(c);
        }

        return copy;
    }
}