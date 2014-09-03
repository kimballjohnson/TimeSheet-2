using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace Timesheet.Domain
{
    [Table(Name = "T_Configuracao")]
    public class Configuracao
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public bool ExportarExcel { get; set; }

        [Column]
        public bool EnviarPorEmail { get; set; }

        [Column]
        public int HorasTrabalho { get; set; }

        [Column]
        public int HorasAlmoco { get; set; }

        [Column]
        public int HorasCompensacao { get; set; }

        [Column]
        public string Email { get; set; }

    }
}
