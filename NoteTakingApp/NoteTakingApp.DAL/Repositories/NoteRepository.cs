using NoteTakingApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.DAL.Repositories
{
    public class NoteRepository
    {
        private static NoteRepository instance = null;

        private static string dataPath = @"..\..\..\..\NoteTakingApp.DAL\Data\Notes_Data.csv";
        private static string deletedDataPath = @"..\..\..\..\NoteTakingApp.DAL\Data\Deleted_Notes_Data.csv";

        private List<Note> notesList = GetNotesFromFile(dataPath);
        private List<Note> deletedNotesList = GetNotesFromFile(deletedDataPath);


        public static NoteRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new NoteRepository();
            }
            return instance;
        }

        private static List<Note> GetNotesFromFile(string filePath)
        {
            StreamReader reader = new StreamReader(File.OpenRead(filePath));
            List<Note> notes = new List<Note>();

            while (!reader.EndOfStream)
            {
                Note note = new Note();

                string line = reader.ReadLine();
                if (line == "") continue;

                string[] lineArray = line.Split(",");

                note.Id = int.Parse(lineArray[0]);
                note.Title = lineArray[1];
                note.Description = lineArray[2];
                note.LastModified = lineArray[3];
                note.Favourite = lineArray[4];

                notes.Add(note);
            }

            reader.Close();

            return notes;
        }

        private Note GetNoteById(int id, List<Note> list)
        {
            return list.Find(note => note.Id == id);
        }

        // Create
        public void AddNote(Note newNote)
        {
            notesList.Add(newNote);

            string textToAppend = newNote.Id == 1 ? "" : "\n";
            textToAppend += $"{newNote.Id},{newNote.Title},{newNote.Description},{newNote.LastModified},{newNote.Favourite}";

            File.AppendAllText(dataPath, textToAppend);
        }


        // Convert
        public Note ConvertNote(string title, string description, string favourite)
        {
            Note note = new Note();
            note.Id = File.ReadAllLines(dataPath).Length + 1;
            
            title = title.Replace(Environment.NewLine, "[NEWLINE]");
            title = title.Replace(",", "[COMMA]");

            description = description.Replace(Environment.NewLine, "[NEWLINE]");
            description = description.Replace(",", "[COMMA]");

            note.Title = title;
            note.Description = description;
            note.LastModified = DateTime.Now.ToString("d/M/yyyy h:mm tt");
            note.Favourite = favourite;
            return note;
        }

        // Update
        public void UpdateNote(int id, string title, string description, string favourite)
        {
            string[] lines = File.ReadAllLines(dataPath);

            title = title.Replace(Environment.NewLine, "[NEWLINE]");
            title = title.Replace(",", "[COMMA]");
            
            description = description.Replace(Environment.NewLine, "[NEWLINE]");
            description = description.Replace(",", "[COMMA]");

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(id + ","))
                {
                    lines[i] = id.ToString() + ',' + title + ',' + description + ',' + DateTime.Now.ToString("d/M/yyyy h:mm tt") + ',' + favourite;
                }
            }

            WriteText(lines, dataPath);
        }

        // Delete
        public void DeleteNote(int id)
        {
            string[] lines = File.ReadAllLines(dataPath);

            lines = lines.Where(line => !line.StartsWith(id + ",")).ToArray();

            WriteDeletedNote(GetNoteById(id, notesList));
            WriteText(ReorderNotes(lines, id), dataPath);
        }

        // Reorder

        public string[] ReorderNotes(string[] lines, int id)
        {
            for (int i = id - 1; i < lines.Length; i++)
            {
                string[] lineArray = lines[i].Split(',');
                int newId = int.Parse(lineArray[0]);
                newId--;
                lineArray[0] = newId.ToString();
                lines[i] = string.Join(",", lineArray);
            }

            return lines;
        }

        private void WriteText(string[] lines, string filePath)
        {
            string textToWrite = string.Join("\n", lines);

            File.WriteAllText(filePath, textToWrite);

            notesList = GetNotesFromFile(dataPath);
            deletedNotesList = GetNotesFromFile(deletedDataPath);
        }

        // Move note to deleted notes file
        private void WriteDeletedNote(Note deletedNote)
        {
            deletedNote.Id = File.ReadAllLines(deletedDataPath).Length + 1;

            string textToAppend = deletedNote.Id == 1 ? "" : "\n";
            textToAppend += $"{deletedNote.Id},{deletedNote.Title},{deletedNote.Description},{deletedNote.LastModified},{deletedNote.Favourite}";

            deletedNotesList.Add(deletedNote);
            File.AppendAllText(deletedDataPath, textToAppend);
        }

        // Restore note
        public void RestoreNote(int id)
        {
            Note restoredNote = GetNoteById(id, deletedNotesList);
            restoredNote.Id = File.ReadAllLines(dataPath).Length + 1;

            AddNote(restoredNote);
            
            DeleteNotePermanently(id);
        }

        // Delete permanently
        public void DeleteNotePermanently(int id)
        {
            string[] lines = File.ReadAllLines(deletedDataPath);

            lines = lines.Where(line => !line.StartsWith(id + ",")).ToArray();

            WriteText(ReorderNotes(lines, id), deletedDataPath);
        }

        public string[] ReadNotes()
        {
            string[] lines = File.ReadAllLines(dataPath);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace("[NEWLINE]", Environment.NewLine);
            }

            return lines;
        }

        public string[] ReadDeletedNotes()
        {
            string[] lines = File.ReadAllLines(deletedDataPath); ;

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace("[NEWLINE]", Environment.NewLine);
            }

            return lines;
        }
    }
}