using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Http
{
    internal class Result
    {
        public string status { get; set; }
        public object data { get; set; }
    }
}
