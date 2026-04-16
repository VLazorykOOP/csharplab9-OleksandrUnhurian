namespace Tasks {
class Task4
{
    public static void Run()
    {
        Catalog catalog = new Catalog();

        MusicDisk disk1 = new MusicDisk("Rock Hits");
        MusicDisk disk2 = new MusicDisk("Pop Collection");

        disk1.AddSong(new Song("Song1", "Artist1", 3.5));
        disk1.AddSong(new Song("Song2", "Artist2", 4.0));

        disk2.AddSong(new Song("Song3", "Artist1", 2.8));
        disk2.AddSong(new Song("Song4", "Artist3", 3.2));

        catalog.AddDisk(disk1);
        catalog.AddDisk(disk2);

        Console.WriteLine("=== ALL CATALOG ===");
        catalog.ShowAll();

        Console.WriteLine("\n=== SEARCH ===");
        catalog.FindByArtist("Artist1");

        disk1.RemoveSong("Song1");
        catalog.RemoveDisk("Pop Collection");

        Console.WriteLine("\n=== AFTER DELETE ===");
        catalog.ShowAll();
    }
}
}