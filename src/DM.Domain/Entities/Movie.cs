using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Domain.Enums;

namespace DM.Domain.Entities
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime Date { get; set; }
      

        public ICollection<Actor> Actors { get; set; }
      



    }
}
