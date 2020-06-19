using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used.Models
{
    public class ConnectedUser
    {
        [Key]
        public string ConnectionId { get; set; }
        public string UserId { get; set; }
    }
}
