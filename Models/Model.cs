using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookMine.Models
{
    public class Model
    {

        public class Author
        {
            public int Id { get; set; }
            
            //bio
            [Required]
            public string LastName { get; set; }
            [Required]
            public string FirstName { get; set; }

            [DisplayFormat(DataFormatString = "{0:M-d-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime Birth { get; set; }
            [DisplayFormat(DataFormatString = "{0:M-d-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime Death { get; set; }

            public virtual Country Nationality { get; set; }

            public virtual ICollection<Book> Books { get; set; }

        }

        public class Book
        {
            public int Id { get; set; }

            [Required]
            public string Title { get; set; }
            [DisplayFormat(DataFormatString = "{0:M-d-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime Published { get; set; }

            public virtual Author Author { get; set; }
          
        }

        public class Word
        {
            public int Id { get; set; }

            [Required]
            public string Word { get; set; }

        }

        public class Country
        {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }
        }
    }
}