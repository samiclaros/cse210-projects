using System.IO; 
using System;
using System.Text;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _file; 

    public void AddEntry(Entry newEntry)
    {
        // Put new entry into _entries
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Display all of the entries in the _entries list
        foreach (Entry entry in _entries)
        {
            entry.Display();
            // Console.WriteLine(entry)
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        // Loop trhough each item in _entries and save it in a file
        using StreamWriter outputFile = new(_file);
        foreach (Entry entry in entries)
        {
            outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
        
        public void LoadFromFile(string _file)
    {
        // Loop through each line of the file and create Entry objects to put in the list
        // string filename = file;
        string[] lines = System.IO.File.ReadAllLines(_file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new()
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
        }
    }   
}