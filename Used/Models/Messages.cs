using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used.Models
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Sender))]
        public string SenderId { get; set; }
        [ForeignKey(nameof(Receiver))]
        public string ReceiverId { get; set; }
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Receiver { get; set; }
    }
}
