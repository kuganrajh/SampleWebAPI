using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.BO
{
    [Table("Student", Schema = "App")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "DOB Required")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "BatchId Required")]
        public int BatchId { get; set; }

        [ForeignKey("BatchId")]
        public Batch Batch { get; set; }
    }
}
