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
    public  class NoteRepository
    {
        private static NoteRepository instance = null;
        private List<Note> notesList = GetNotesFromFile();

        private static string filePath = @"..\..\..\..\NoteTakingApp.DAL\Data\Notes_Data.csv";


        public static NoteRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new NoteRepository();
            }
            return instance;
        }

        private static List<Note> GetNotesFromFile()
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

        public List<Note> GetNotes()
        {
            return notesList;
        }

        // Get note by ID
        public Note GetNoteById(int id)
        {
            return notesList.Find(note => note.Id == id);
        }


        // Create
        public void AddNote(Note newNote)
        {
            notesList.Add(newNote);

            File.AppendAllText(filePath, '\n' + $"{newNote.Id},{newNote.Title},{newNote.Description},{newNote.LastModified},{newNote.Favourite}");
        }


        // Convert
        public Note ConvertNote(string title, string description, string favourite)
        {
            Note note = new Note();
            note.Id = File.ReadAllLines(filePath).Length + 1;
            note.Title = title;
            note.Description = description.Replace("\n", "[NEWLINE]");
            note.LastModified = DateTime.Now.ToString("d/M/yyyy h:mm tt");
            note.Favourite = favourite;
            return note;
        }

        // Update
        public void UpdateNote(int id, string title, string description, string favourite)
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(id + ","))
                {
                    lines[i] = id.ToString() + ',' + title + ',' + description + ',' + DateTime.Now.ToString("d/M/yyyy h:mm tt") + ',' + favourite;
                }
            }

            WriteText(lines);
        }

        // Delete
        public void DeleteNote(int id)
        {
            string[] lines = File.ReadAllLines(filePath);

            lines = lines.Where(line => !line.StartsWith(id + ",")).ToArray();

            WriteText(ReorderNotes(lines, id));
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

        private static void WriteText(string[] lines)
        {
            string textToWrite = string.Join("\n", lines);

            File.WriteAllText(filePath, textToWrite);
        }

        public string[] ReadCsvFile()
        {
            string[] lines = File.ReadAllLines(filePath);

            return lines;
        }
    }
}
