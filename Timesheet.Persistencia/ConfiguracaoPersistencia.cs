using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Domain;

namespace Timesheet.Persistencia
{
    public class ConfiguracaoPersistencia
    {

        public static void Inserir(ref Domain.Configuracao obj)
        {
            Timesheet.DataBase.TimeSheetContext db = DefaultDataBase.Context;
            Configuracao _achei = null;
            _achei = obj;
            db.ConfigSystem.InsertOnSubmit(_achei);
            db.SubmitChanges();
            obj = (from a in DefaultDataBase.Context.ConfigSystem select a).FirstOrDefault();
        }


        public static void Alterar(ref Domain.Configuracao obj)
        {
            DefaultDataBase.Context.SubmitChanges();

            obj = (from a in DefaultDataBase.Context.ConfigSystem select a).FirstOrDefault();

        }

    }
}
