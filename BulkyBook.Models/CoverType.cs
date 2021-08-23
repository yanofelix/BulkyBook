using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    [Table("CoverTypes")]
    public class CoverType
    {

        [Key]
        public int Id { get; set; }

        [Display(Name ="Cover Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
