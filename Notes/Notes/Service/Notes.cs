using System.Collections.Generic;
using Notes.Models;
using System.IO;

namespace Notes.Service
{
    public class Notess
    {

        public static IEnumerable<Note> Get()
        {
            var notes = new List<Note>();
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var filename in files)
            {
                notes.Add(new Note
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                });
            }
            return notes;

        }
    }
}
