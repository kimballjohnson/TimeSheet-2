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
using System.Linq;
using System.Data.Linq.Mapping;


namespace WP8.Timesheet.Domain
{
    [Table(Name="T_Usuario")]
    public class Usuario
    {

        private long _id;

        [Column(Name="IdUsuario", IsPrimaryKey=true, IsDbGenerated=true)]
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _user;

        [Column(Name="Login_Usuario")]
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _password;

        [Column(Name = "Login_Password")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
      
    }
}
