using NoteTakingApp.DAL.Models;
using System;
using System.Collections.Generic;
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
                note.LastModified = DateTime.Parse(lineArray[3]);

                notes.Add(note);
            }

            reader.Close();

            return notes;
        }

        public List<Note> GetNotes()
        {
            return notesList;
        }
    }
}
