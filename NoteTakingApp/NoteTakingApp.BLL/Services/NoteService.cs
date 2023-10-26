using NoteTakingApp.DAL.Repositories;
using NoteTakingApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

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

        public void CreateNote(int id, string title, string description)
        {
            repositoryInstance.AddNote(ConvertNote(id, title, description));
        }

        public static Note ConvertNote(int id, string title, string description)
        {
            Note note = new Note();

            note.Id = id;
            note.Title = title;
            note.Description = description;
            note.LastModified = DateTime.Now;

            return note;
        }

        public void UpdateNote(int id, string title, string description)
        {
            repositoryInstance.UpdateNote(id, title, description);
        }

        public void DeleteNote(int id)
        {
            repositoryInstance.DeleteNote(id);
        }
    }
}