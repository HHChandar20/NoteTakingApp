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
        private static NoteController instance;
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
        public void CreateNewNote(int id, string title, string description, string favourite)
        {
            serviceInstance.CreateNote(id, title, description, favourite);
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

        public string[] ReadFromCsvFile()
        {
            return serviceInstance.ReadCsvFile();
        }
    }
}
