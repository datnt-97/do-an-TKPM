using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Model
{
    [Table("District")]
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string ProvinceCode { get; set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Street> Streets { get; set; }
        public virtual Province Province { get; set; }

        public override string? ToString()
        {
            return Description ?? Name;
        }
    }
}
