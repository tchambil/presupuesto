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
    public class DAEspecificoDeGasto
    {
        SqlConnection con = new CONEXION_DAL().getConexion();

        
        public void AgregarEspecificaDeGasto(EspecificoDeGasto_BUS esp)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_A_SICOP_ESPECIFICADEGASTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", esp.EGAS_VCH_IDESPECIFICADEGASTO);
            cmd.Parameters.AddWithValue("@EGAS_VCH_DESCRIPCION", esp.EGAS_VCH_DESCRIPCION);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ModificarEspecificaDeGasto(EspecificoDeGasto_BUS esp)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_U_SICOP_ESPECIFICADEGASTO", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", esp.EGAS_VCH_IDESPECIFICADEGASTO);
            cmd.Parameters.AddWithValue("@EGAS_VCH_DESCRIPCION", esp.EGAS_VCH_DESCRIPCION);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable VerEspecificasDeGastos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_S_SICOP_ESPECIFICADEGASTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
