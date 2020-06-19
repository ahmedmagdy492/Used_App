using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        [ForeignKey(nameof(Creator))]
        public string UserId { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public ApplicationUser Creator { get; set; }
        public Category Category { get; set; }
    }
}
