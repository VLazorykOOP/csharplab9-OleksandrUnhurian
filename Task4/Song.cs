using System;

class Song : ICloneable
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public double Duration { get; set; }

    public Song(string title, string artist, double duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public object Clone()
    {
        return new Song(Title, Artist, Duration);
    }

    public override string ToString()
    {
        return $"{Title} - {Artist} ({Duration} min)";
    }
}