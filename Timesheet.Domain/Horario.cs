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
    [Table(Name="T_RegistroHorario")]
    public class Horario
    {
        [Column(IsPrimaryKey=true, IsDbGenerated=true)]
        public int Id { get; set; }

        [Column(CanBeNull=false)]
        public DateTime DataRegistro { get; set; }

        [Column(CanBeNull=false)]
        public DateTime HoraEntrada { get; set; }

        [Column(CanBeNull = false)]
        public DateTime HoraAlmoco { get; set; }

        [Column(CanBeNull = false)]
        public DateTime HoraVoltaAlmoco { get; set; }

        [Column(CanBeNull = false)]
        public DateTime HoraSaida { get; set; }

        [Column(CanBeNull=false)]
        public int CodigoCliente { get; set; }

    }
}
