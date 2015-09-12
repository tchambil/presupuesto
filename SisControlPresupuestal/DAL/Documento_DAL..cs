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
    public class DADocumento
    {

        SqlConnection con = new CONEXION_DAL().getConexion();

        public DataTable VerDocumentos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_S_SICOP_DOCUMENTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //public void AgregarDocumento(DocumentosVO docs)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPR_AgregarMeta", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@nroMeta", meta.NroMeta);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
    }
}
