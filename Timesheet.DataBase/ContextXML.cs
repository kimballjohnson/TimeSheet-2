using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.IO.IsolatedStorage;
using System.IO;
using System.Text;


namespace Timesheet.DataBase
{
    public class ContextXML
    {

        public ContextXML()
        {
            IsolatedStorageFile savegameStorage = IsolatedStorageFile.GetUserStoreForApplication();

            
            savegameStorage.CreateDirectory("Horario");
            
            savegameStorage.CreateDirectory("Cliente");
            
            savegameStorage.CreateDirectory("Tarefa");
            
            savegameStorage.CreateDirectory("Usuario");
            
            savegameStorage.CreateDirectory("Config");




        }

    }
}
