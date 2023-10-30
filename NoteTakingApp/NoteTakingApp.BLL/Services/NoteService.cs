using NoteTakingApp.DAL.Repositories;
using NoteTakingApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Globalization;

namespace NoteTakingApp.BLL.Services
{
    public class NoteService
    {
        private static NoteService instance = null;
        private static NoteRepository repositoryInstance = NoteRepository.GetInstance();

        public static NoteService GetInstance()
        {
            if (instance == null)
            {
                instance = new NoteService();
            }

            return instance;
        }

        private NoteService()
        {

        }

        public List<Note> GetNotes()
        {
            return repositoryInstance.GetNotes();
        }

        public Note GetNoteById(int id)
        {
            return repositoryInstance.GetNoteById(id);
        }

        public void CreateNote(int id, string title, string description, string favourite)
        {
            repositoryInstance.AddNote(ConvertNote(id, title, description, favourite));
        }

        public static Note ConvertNote(int id, string title, string description, string favourite)
        {
            Note note = new Note();

            note.Id = id;
            note.Title = title;
            note.Description = description.Replace("\n", "[NEWLINE]");
            note.LastModified = DateTime.Now.ToString("d/M/yyyy h:mm tt");
            note.Favourite = favourite;
            return note;
        }

        public void UpdateNote(int id, string title, string description, string favourite)
        {
            repositoryInstance.UpdateNote(id, title, description, favourite);
        }

        public void DeleteNote(int id)
        {
            repositoryInstance.DeleteNote(id);
        }

        public string[] ReadCsvFile()
        {
            return repositoryInstance.ReadCsvFile();
        }
    }
}