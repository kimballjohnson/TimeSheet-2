using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Domain;

namespace Timesheet.Persistencia
{
    public class ClientePersistencia
    {
        
        public static void Inserir(ref Domain.Cliente obj)
        {
            Timesheet.DataBase.TimeSheetContext db =DefaultDataBase.Context;
            Cliente _achei = null;
            _achei = obj;
            db.MeuCliente.InsertOnSubmit(_achei);
            db.SubmitChanges();

            obj = (from a in DefaultDataBase.Context.MeuCliente where a.Nome == _achei.Nome select a).FirstOrDefault();
            
        }

        public void Deletar(ref Domain.Cliente obj)
        {
            Cliente _achei = null;
            _achei = obj;

            DefaultDataBase.Context.MeuCliente.DeleteOnSubmit(_achei);
            DefaultDataBase.Context.SubmitChanges();
        }

        public void Alterar(ref Domain.Cliente obj)
        {
            DefaultDataBase.Context.SubmitChanges();
        }

        public Domain.Cliente BuscarPorId(int obj)
        {
            Cliente _achei = null;
            int _codigo = obj;

            _achei = (from a in DefaultDataBase.Context.MeuCliente where a.Id == _codigo select a).FirstOrDefault();

            return _achei;
        }

        public static IList<Domain.Cliente> BuscarTodos(int obj)
        {
            IList<Cliente> _lista = null;
            _lista = (from a in DefaultDataBase.Context.MeuCliente select a).ToList();
            return _lista;
        }
    }
}
