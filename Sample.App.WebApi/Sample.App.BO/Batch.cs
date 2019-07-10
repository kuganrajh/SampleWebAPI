using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.BO
{
    [Table("Batch", Schema = "App")]
    public class Batch
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
