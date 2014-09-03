using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Domain
{
    [Table(Name="T_Usuario")]
    public class Usuario
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string TipoRegistro { get; set; }

        [Column]
        public string Login { get; set; }

        [Column]
        public string Senha { get; set; }

        [Column]
        public string Aparelho { get; set; }

        [Column]
        public DateTime DataRegistro { get; set; }
    }
}
