using System.IO; 
public class Journal {

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){

        Entry entry = newEntry;
        _entries.Add(entry);
    }
    public void DisplayAll(){
        foreach (Entry list in _entries){
                list.Display();
            }
    }
    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            outputFile.WriteLine($"{_entries}");
        }
    }
    public void LoadFromFile(string file){

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        }
    }

}