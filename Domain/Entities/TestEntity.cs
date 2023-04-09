using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Test")]
    public class TestModel
    {
        [Key]
        [Column("Name_Update")]
        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
