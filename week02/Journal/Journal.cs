using System.IO;

public class Journal
{
    public List<Entry> _entrys = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entrys.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entrys in _entrys)
            {
                entrys.DisplayEntry();
            }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entrys in _entrys)
            {
                outputFile.WriteLine($"{entrys._date}~|~{entrys._entryText}~|~{entrys._promptText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            
            foreach (Entry entrys in _entrys)
            {
                entrys._date = parts[0];
                entrys._entryText = parts[1];
                entrys._promptText = parts[3];
            }
        }
    }
}