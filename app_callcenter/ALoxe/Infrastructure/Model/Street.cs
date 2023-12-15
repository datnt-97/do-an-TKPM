using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Model
{
    [Table("Street")]
    public class Street
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string DistrictCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }

        public override string? ToString()
        {
            return Description ?? Name;
        }
    }
}
