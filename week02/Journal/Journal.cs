public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DispayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        //string filename = "myFile.txt";//

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine("This will be the first line the file.");

            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public void LoadFromFile(string file)
    {
        
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}