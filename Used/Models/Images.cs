using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProfileImage { get; set; }
        public bool IsCoverImage { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
