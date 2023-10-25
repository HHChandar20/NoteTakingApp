using SimpleLoginSystem.DAL.Repositories;
using SimpleLoginSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}