using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Domain;

namespace Timesheet.Persistencia
{
    public class TarefasPersistencia
    {

        public void Inserir(ref Domain.Tarefas obj)
        {
            Tarefas _achei = null;
            _achei = obj;

            var result = (from a in DefaultDataBase.Context.MinhasTarefas where a.CodigoHorario == _achei.CodigoHorario && a.DataRegistro == _achei.DataRegistro select a).FirstOrDefault();

            if (result == null)
            {
                DefaultDataBase.Context.MinhasTarefas.InsertOnSubmit(_achei);
            }
            DefaultDataBase.Context.SubmitChanges();
            obj = _achei;
        }

        public void Deletar(ref Domain.Tarefas obj)
        {
            Tarefas _achei = null;
            _achei = obj;
            var result = (from a in DefaultDataBase.Context.MinhasTarefas where a.CodigoHorario == _achei.CodigoHorario && a.DataRegistro == _achei.DataRegistro select a).FirstOrDefault();
            if (result != null)
            {
                DefaultDataBase.Context.MinhasTarefas.DeleteOnSubmit(_achei);
            }
            DefaultDataBase.Context.SubmitChanges();
        }

        public void Alterar(ref Domain.Tarefas obj)
        {
            DefaultDataBase.Context.SubmitChanges();
        }

        public Domain.Tarefas BuscarPorId(int obj)
        {
            Tarefas _achei = null;
            int _codigo = obj;

            _achei = (from a in DefaultDataBase.Context.MinhasTarefas where a.Id == _codigo select a).FirstOrDefault();

            return _achei;
        }

        public IList<Domain.Tarefas> BuscarTodos(int obj)
        {
            IList<Tarefas> _lista = null;
            _lista = (from a in DefaultDataBase.Context.MinhasTarefas select a).ToList();
            return _lista;
        }
    }
}
