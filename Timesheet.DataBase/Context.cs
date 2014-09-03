using System;
using System.Data.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Timesheet.DataBase
{
    public class TimeSheetContext : DataContext
    {
        public static string DbConnectionString = "Data Source=isostore:/GetEmpresaTimeSheetDB_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".sdf";

        public TimeSheetContext() : base(DbConnectionString) { }

        //tabelas
        public Table<Timesheet.Domain.Horario> MeusHorarios { get { return this.GetTable<Timesheet.Domain.Horario>(); } }

        public Table<Timesheet.Domain.Cliente> MeuCliente { get { return this.GetTable<Timesheet.Domain.Cliente>(); } }

        public Table<Timesheet.Domain.Tarefas> MinhasTarefas { get { return this.GetTable<Timesheet.Domain.Tarefas>(); } }

        public Table<Timesheet.Domain.Usuario> UsuarioSistema { get { return this.GetTable<Timesheet.Domain.Usuario>(); } }

        public Table<Timesheet.Domain.Configuracao> ConfigSystem { get { return this.GetTable<Timesheet.Domain.Configuracao>(); } }

    }
}
