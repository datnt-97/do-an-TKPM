using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Model
{
    [Table("Province")]
    public class Province
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<District> Districts { get; set; }

        public override string? ToString()
        {
            return Description ?? Name;
        }
    }
}
