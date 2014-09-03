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
    [Table(Name = "T_Cliente")]
    public class Cliente
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string Nome { get; set; }

        [Column]
        public string Endereco { get;set;}

        [Column]
        public string Latitude { get; set; }

        [Column]
        public string Longitude { get; set; }

    }
}
