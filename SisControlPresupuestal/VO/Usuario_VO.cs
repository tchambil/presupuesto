using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Usuario_VO
    {
        private int _USU_INT_IDUSUARIO;

        public int USU_INT_IDUSUARIO
        {
            get { return _USU_INT_IDUSUARIO; }
            set { _USU_INT_IDUSUARIO = value; }
        }

        private string _USU_VCH_NOMBRE;

        public string USU_VCH_NOMBRE
        {
            get { return _USU_VCH_NOMBRE; }
            set { _USU_VCH_NOMBRE = value; }
        }
        private string _USU_VCH_APELLIDOS;

        public string USU_VCH_APELLIDOS
        {
            get { return _USU_VCH_APELLIDOS; }
            set { _USU_VCH_APELLIDOS = value; }
        }
        private string _USU_VCH_USUARIO;

        public string USU_VCH_USUARIO
        {
            get { return _USU_VCH_USUARIO; }
            set { _USU_VCH_USUARIO = value; }
        }
        private string _USU_VCH_PASSWORD;

        public string USU_VCH_PASSWORD
        {
            get { return _USU_VCH_PASSWORD; }
            set { _USU_VCH_PASSWORD = value; }
        }
    }
}
