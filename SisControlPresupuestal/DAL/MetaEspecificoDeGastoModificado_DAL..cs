using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAMetaEspecificoDeGastoModificado
    {
        SqlConnection con = new CONEXION_DAL().getConexion();
        public void AgregarMetaEspecificaDeGastoModificaciones(MetaEspecificoDeGastoModificado_VO mem)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_A_SICOP_META_ESPECIFICADEGASTO_MODIFICACIONES", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@META_VCH_IDMETA", mem.META_VCH_IDMETA);
            cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", mem.EGAS_VCH_IDESPECIFICADEGASTO);
            cmd.Parameters.AddWithValue("@MEGM_DEC_PIMMODIFICADO", mem.MEGM_DEC_PIMMODIFICADO);
            cmd.ExecuteNonQuery();
            con.Close();
        }
     
    }
}
