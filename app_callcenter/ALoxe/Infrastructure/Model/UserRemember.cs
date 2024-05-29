using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALoxe;
using ALoxe.Infrastructure;
using ALoxe.Infrastructure.Data;
using ALoxe.Infrastructure.Model;

namespace ALoxe.Infrastructure.Model
{
    [Table("UserRemember")]
    public class UserRemember
    {
        [Key]
        public string Phone { get; set; }
        public string Pasword { get; set; }

    }
}
