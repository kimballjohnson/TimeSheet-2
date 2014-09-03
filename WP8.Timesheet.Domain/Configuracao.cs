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
    [Table(Name="T_ConfiguracaoUsuario")]
    public class Configuracao
    {
        private int _id;

         [Column(Name = "IdConfiguracao", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private decimal _almoco;

        [Column]
        public decimal Almoco
        {
            get { return _almoco; }
            set { _almoco = value; }
        }

        private bool _isHorasFechadas;

        [Column]
        public bool IsHorasFechadas
        {
            get { return _isHorasFechadas; }
            set { _isHorasFechadas = value; }
        }

        private int _horasFechadasMes;

        [Column]
        public int HorasFechadasMes
        {
            get { return _horasFechadasMes; }
            set { _horasFechadasMes = value; }
        }

        private int _horasDia;

        [Column]
        public int HorasDia
        {
            get { return _horasDia; }
            set { _horasDia = value; }
        }

        private int _compensancao;

        [Column]
        public int Compensancao
        {
            get { return _compensancao; }
            set { _compensancao = value; }
        }
        
        private bool _isSendMail;

        [Column]
        public bool IsSendMail
        {
            get { return _isSendMail; }
            set { _isSendMail = value; }
        }

        private bool _isGenerateExcel;

        [Column]
        public bool IsGenerateExcel
        {
            get { return _isGenerateExcel; }
            set { _isGenerateExcel = value; }
        }

        private bool _isSyncGoogleDrive;

        [Column]
        public bool IsSyncGoogleDrive
        {
            get { return _isSyncGoogleDrive; }
            set { _isSyncGoogleDrive = value; }
        }

        private bool _isSyncOneDrive;

        [Column]
        public bool IsSyncOneDrive
        {
            get { return _isSyncOneDrive; }
            set { _isSyncOneDrive = value; }
        }

        private string _aliasStringExcel;

        [Column]
        public string AliasStringExcel
        {
            get { return _aliasStringExcel; }
            set { _aliasStringExcel = value; }
        }

        private string _email;

        [Column]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private bool _isGraficoGenerate;

        [Column]
        public bool IsGraficoGenerate
        {
            get { return _isGraficoGenerate; }
            set { _isGraficoGenerate = value; }
        }

    }
}
