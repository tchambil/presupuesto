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
   public  class DAMetaEspecificoDeGasto
    {
       SqlConnection con = new CONEXION_DAL().getConexion();
       public void AgregarMetaEspecificaDeGasto(MetaEspecificoDeGasto_VO metesp)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("USP_A_SICOP_META_ESPECIFICADEGASTO", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@META_VCH_IDMETA", metesp.META_VCH_IDMETA);
           cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", metesp.EGAS_VCH_IDESPECIFICADEGASTO);
           cmd.Parameters.AddWithValue("@MEGA_DEC_PIM", metesp.MEGA_DEC_PIM);
           cmd.Parameters.AddWithValue("@MEGA_VCH_ANIO", metesp.MEGA_VCH_ANIO);
           cmd.ExecuteNonQuery();
           con.Close();
       }
     
       public DataTable BusquedaDeMetaEspecificaDeGasto(string META_VCH_IDMETA)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("USP_S_SICOP_META_ESPECIFICADEGASTO_REPORT", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@_META_VCH_IDMETA", META_VCH_IDMETA);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }   
    }
}
