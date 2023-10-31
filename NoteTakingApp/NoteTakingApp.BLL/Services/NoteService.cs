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

        public void CreateNote(string title, string description, string favourite)
        {
            repositoryInstance.AddNote(repositoryInstance.ConvertNote(title, description, favourite));
        }

        public void UpdateNote(int id, string title, string description, string favourite)
        {
            repositoryInstance.UpdateNote(id, title, description, favourite);
        }

        public void DeleteNote(int id)
        {
            repositoryInstance.DeleteNote(id);
        }

        public string[] ReadNotes()
        {
            return repositoryInstance.ReadNotes();
        }

        public string[] ReadDeletedNotes()
        {
            return repositoryInstance.ReadDeletedNotes();
        }

        public void RestoreNote(int id)
        {
            repositoryInstance.RestoreNote(id);
        }

        public void DeleteNotePermanently(int id)
        {
            repositoryInstance.DeleteNotePermanently(id);
        }
    }
}