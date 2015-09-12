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
    public class DAMeta
    {
        SqlConnection con = new CONEXION_DAL().getConexion();
        public DataTable VerMetas()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_S_SICOP_META", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
