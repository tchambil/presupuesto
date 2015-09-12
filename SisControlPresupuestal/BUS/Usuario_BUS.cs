using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using DAL;

namespace BUS
{
    public class Usuario_BUS
    {
        public Usuario_VO Login(string usuario, ref bool encuentra)
        {
            DAUsuario usuDAL = new DAUsuario();
            DataTable dt = usuDAL.Login(usuario);
            Usuario_VO usuVO = new Usuario_VO();
            foreach (DataRow dr in dt.Rows)
            {
                encuentra = true;
                usuVO.USU_INT_IDUSUARIO = Convert.ToInt32(dr["idUsuario"].ToString());
                usuVO.USU_VCH_NOMBRE = dr["nombre"].ToString();
                usuVO.USU_VCH_APELLIDOS = dr["apellidos"].ToString();
                usuVO.USU_VCH_USUARIO = dr["usuario"].ToString();
                usuVO.USU_VCH_PASSWORD = dr["pass"].ToString();
            }
            return usuVO;
        }
        //public DataTable VerUsuarios()
        //{
        //    return new UsuarioDAL().VerUsuarios();
        //}

    }
}
