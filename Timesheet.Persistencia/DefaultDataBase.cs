using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Persistencia
{
    public class DefaultDataBase
    {
        public static Timesheet.DataBase.TimeSheetContext Context
        {
            get
            {
                Timesheet.DataBase.TimeSheetContext db = new DataBase.TimeSheetContext();
                if (db.DatabaseExists() == false)
                {
                    db.CreateDatabase();
                    SetDefaultConfiguration();

                }
                return db;
            }
        }

        private static void SetDefaultConfiguration()
        {
            Timesheet.Domain.Configuracao _config = new Domain.Configuracao();
            _config.EnviarPorEmail = true;
            _config.ExportarExcel = true;
            _config.HorasAlmoco = 1;
            _config.HorasCompensacao = 0;
            _config.HorasTrabalho = 8;

            ConfiguracaoPersistencia.Inserir(ref _config);

        }
    }
}
