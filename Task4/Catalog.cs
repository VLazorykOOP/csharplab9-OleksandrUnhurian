using System;
using System.Collections;

class Catalog : IEnumerable
{
    private Hashtable disks = new Hashtable();

    public void AddDisk(MusicDisk disk)
    {
        disks[disk.Name] = disk;
    }

    public void RemoveDisk(string name)
    {
        disks.Remove(name);
    }

    public void ShowAll()
    {
        foreach (DictionaryEntry entry in disks)
        {
            ((MusicDisk)entry.Value).ShowSongs();
            Console.WriteLine();
        }
    }

    public void ShowDisk(string name)
    {
        if (disks.ContainsKey(name))
        {
            ((MusicDisk)disks[name]).ShowSongs();
        }
    }

    public void FindByArtist(string artist)
    {
        Console.WriteLine($"Songs by {artist}:");

        foreach (MusicDisk disk in disks.Values)
        {
            foreach (Song song in disk)
            {
                if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{song} [Disk: {disk.Name}]");
                }
            }
        }
    }

    public IEnumerator GetEnumerator()
    {
        return disks.Values.GetEnumerator();
    }
}