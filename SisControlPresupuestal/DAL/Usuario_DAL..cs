using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAUsuario
    {
        SqlConnection con = new CONEXION_DAL().getConexion();

        public DataTable Login(string usuario)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPR_Login",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu",usuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //public DataTable VerUsuarios()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPR_VerUsuarios", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;
        //}
    }
}
