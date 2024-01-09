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

        using (TextWriter outputFile = new StreamWriter(file)){

            foreach (Entry item in _entries){

                outputFile.WriteLine($"{item._date}");
                outputFile.WriteLine($"{item._promptText}");
                outputFile.WriteLine($"{item._entryText}");
            }
        }
    } 
    public void LoadFromFile(string file){

        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i = i + 3){

            Entry entry = new Entry();
            entry._date = lines[i];
            entry._promptText = lines[i+1];
            entry._entryText = lines[i+2];

            _entries.Add(entry);
            }
        }
    }