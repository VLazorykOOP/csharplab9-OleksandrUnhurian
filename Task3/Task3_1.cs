namespace Tasks {
class Task3_1
{
    public static void Run()
    {
        string input = "Task3/" + "input1.txt";
        string output = "Task3/" + "output.txt";

        NumberCollection collection = new NumberCollection();

        string[] parts = File.ReadAllText(input)
            .Split([' ', '\n', '\r', '\t'], StringSplitOptions.RemoveEmptyEntries);

        foreach (var p in parts)
            collection.Add(int.Parse(p));

        collection.Reverse();

        using (StreamWriter writer = new StreamWriter(output))
        {
            foreach (int n in collection)
                writer.Write(n + " ");
        }
    }
}
}