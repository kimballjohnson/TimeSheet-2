using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Domain;

namespace Timesheet.Persistencia
{
    public class UsuarioPersistencia
    {
            public static void Inserir(ref Domain.Usuario obj)
        {
            Usuario _achei = null;
           _achei = obj;

           var result = (from a in DefaultDataBase.Context.UsuarioSistema where a.Login == _achei.Login select a).FirstOrDefault();

            if (result == null)
            {
                DefaultDataBase.Context.UsuarioSistema.InsertOnSubmit(_achei);
            }
            DefaultDataBase.Context.SubmitChanges();
            obj = _achei;
        }

        public static void Deletar(ref Domain.Usuario obj)
        {
            Usuario _achei = null;
            _achei = obj;

            var result = (from a in DefaultDataBase.Context.UsuarioSistema where a.Login == _achei.Login select a).FirstOrDefault();

            if (result != null)
            {
                DefaultDataBase.Context.UsuarioSistema.DeleteOnSubmit(_achei);
            }
            DefaultDataBase.Context.SubmitChanges();
        }

        public static void Alterar(ref Domain.Usuario obj)
        {
            DefaultDataBase.Context.SubmitChanges();
        }

        public static Domain.Usuario BuscarPorId(int obj)
        {
            Usuario _achei = null;
            int _codigo = obj;

            _achei = (from a in DefaultDataBase.Context.UsuarioSistema where a.Id == _codigo select a).FirstOrDefault();

            return _achei;
        
        }

        public static IList<Domain.Usuario> BuscarTodos(int obj)
        {
            IList<Usuario> _lista = null;
            _lista = (from a in DefaultDataBase.Context.UsuarioSistema select a).ToList();
            return _lista;
        }
    }
}
