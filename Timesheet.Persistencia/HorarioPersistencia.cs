using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Timesheet.Domain;
using System.Linq;

namespace Timesheet.Persistencia
{
    public class HorarioPersistencia
    {
        public static void Inserir(ref Domain.Horario obj)
        {
            Horario _achei = null;
            _achei = obj;
            DefaultDataBase.Context.MeusHorarios.InsertOnSubmit(_achei);
            DefaultDataBase.Context.SubmitChanges();
            obj = _achei;
        }

        public static void Deletar(ref Domain.Cliente obj)
        {
            Cliente _achei = null;
            _achei = obj;

            DefaultDataBase.Context.MeuCliente.DeleteOnSubmit(_achei);
            DefaultDataBase.Context.SubmitChanges();
        }

        public static void Alterar(ref Domain.Cliente obj)
        {
            DefaultDataBase.Context.SubmitChanges();
        }

        public static Domain.Cliente BuscarPorId(int obj)
        {
            Cliente _achei = null;
            int _codigo = obj;

            var result = from a in DefaultDataBase.Context.MeuCliente where a.Id == _codigo select a;

            _achei = result.ToList()[0];

            return _achei;
        }

        public static IList<Domain.Cliente> BuscarTodos(int obj)
        {
            IList<Domain.Cliente> result = new List<Cliente>();

            result = (from a in DefaultDataBase.Context.MeuCliente select a).ToList();

            return result;
        }
    }
}
