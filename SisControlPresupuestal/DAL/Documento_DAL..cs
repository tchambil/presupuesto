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

        public DataTable getDocumento()
        {
             

            DataTable mDtDocumento = new DataTable();
            try
            {
                using (SqlConnection sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion))
                {
                    SqlCommand cmdComand = new SqlCommand("USP_S_SICOP_DOCUMENTO", sqlConection);
                    cmdComand.CommandType = CommandType.StoredProcedure;
                    sqlConection.Open();
                    SqlDataAdapter mDaDocumento = new SqlDataAdapter(cmdComand);
                    mDaDocumento.Fill(mDtDocumento);
                    return mDtDocumento;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return mDtDocumento;
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
