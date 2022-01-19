using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Posts
    {
        [Required]
        [Key]
        public int UserId { get; set; }
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Body { get; set; }
    }
}
