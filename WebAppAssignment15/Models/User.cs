using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppAssignment15.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int TId { get; set; }

        public string TName { get; set; }

        public string TEmail { get; set; }

        public string TSlogan { get; set; }
    }
}