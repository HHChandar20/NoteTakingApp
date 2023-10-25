﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.DAL.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime LastModified { get; set; }


        Note()
        {
            Id = 0;
            Title = "Null";
            Description = "Null";
            LastModified = DateTime.Now;
        }

    }
}
