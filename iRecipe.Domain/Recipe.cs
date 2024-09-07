using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipe.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public int Pax { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool Approval { get; set; }
        public int Duration { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public Difficulty Difficulty { get; set; }
        public int DifficultyId { get; set; }
        public byte[] Image { get; set; }

        
    }

}
