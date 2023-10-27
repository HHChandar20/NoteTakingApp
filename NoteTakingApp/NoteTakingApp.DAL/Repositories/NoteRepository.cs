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

                string[] lineArray = line.Split(",");

                note.Id = int.Parse(lineArray[0]);
                note.Title = lineArray[1].ToString();
                note.Description = lineArray[2].ToString();
                note.LastModified = DateTime.ParseExact(lineArray[3], "d/M/yyyy h:mm tt", CultureInfo.InvariantCulture);

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

            File.AppendAllText(filePath, '\n' + newNote.ToString());
        }

        // Update
        public void UpdateNote(int id, string title, string description)
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(id + ","))
                {
                    lines[i] = id.ToString() + ',' + title + ',' + description + ',' + DateTime.Now.ToString();
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        //Delete
        public void DeleteNote(int id)
        {
            string[] lines = File.ReadAllLines(filePath);

            lines = lines.Where(line => !line.StartsWith(id + ",")).ToArray();

            File.WriteAllLines(filePath, lines);
        }
        public string[] ReadCsvFile()
        {
            string[] lines = File.ReadAllLines(filePath);

            return lines;
        }
    }
}
