using System;
using System.Collections;

class MusicDisk : IEnumerable, ICloneable
{
    public string Name { get; set; }

    // Пісні зберігаємо в Hashtable
    private Hashtable songs = new Hashtable();

    public MusicDisk(string name)
    {
        Name = name;
    }

    public void AddSong(Song song)
    {
        songs[song.Title] = song;
    }

    public void RemoveSong(string title)
    {
        songs.Remove(title);
    }

    public void ShowSongs()
    {
        Console.WriteLine($"Disk: {Name}");
        foreach (DictionaryEntry entry in songs)
        {
            Console.WriteLine(entry.Value);
        }
    }

    public IEnumerator GetEnumerator()
    {
        return songs.Values.GetEnumerator();
    }

    public object Clone()
    {
        MusicDisk copy = new MusicDisk(Name);
        foreach (Song song in songs.Values)
        {
            copy.AddSong((Song)song.Clone());
        }
        return copy;
    }
}