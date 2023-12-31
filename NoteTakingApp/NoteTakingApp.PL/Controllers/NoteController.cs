﻿using NoteTakingApp.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.PL.Controllers
{
    public class NoteController
    {
        private static NoteController instance = null;
        private static NoteService serviceInstance = NoteService.GetInstance();

        public static NoteController GetInstance()
        {
            if (instance == null)
            {
                instance = new NoteController();
            }

            return instance;
        }

        private NoteController()
        {

        }

        //Create
        public void CreateNewNote(string title, string description, string favourite)
        {
            serviceInstance.CreateNote(title, description, favourite);
        }

        //Update
        public void UpdateNote(int id, string title, string description, string favourite)
        {
            serviceInstance.UpdateNote(id, title, description, favourite);
        }

        //Delete
        public void DeleteNote(int id)
        {
            serviceInstance.DeleteNote(id);
        }

        public string[] ReadNotes()
        {
            return serviceInstance.ReadNotes();
        }

        public string[] ReadDeletedNotes()
        {
            return serviceInstance.ReadDeletedNotes();
        }

        public void RestoreNote(int id)
        {
            serviceInstance.RestoreNote(id);
        }

        public void DeleteNotePermanently(int id)
        {
            serviceInstance.DeleteNotePermanently(id);
        }
    }
}
