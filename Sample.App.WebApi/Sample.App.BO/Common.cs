using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.BO
{
    public class Common
    {
        public Common()
        {
            this.CreatedAt = DateTime.Now;
            IsActive = true;
        }

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateddAt { get; set; }
    }
}
