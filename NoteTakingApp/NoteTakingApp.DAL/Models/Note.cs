using System;
using System.Collections.Generic;
using System.Globalization;
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

        public string LastModified { get; set; }

        public string Favourite { get; set; }

        public Note()
        {
            Id = 0;
            Title = "Null";
            Description = "Null";
            LastModified = DateTime.Now.ToString("d/M/yyyy h:mm tt");
            Favourite = "♡";
        }

    }
}
