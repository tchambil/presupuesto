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
    public class DADetalleControlPresupuestal
    {

        SqlConnection con = new CONEXION_DAL().getConexion();

        public void AgregarDetalleControlPresupuestal(DetalleControlPresupuestal_VO detconpresu)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_A_SICOP_DETALLECONTROLPRESUPUESTAL", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", detconpresu.CPRE_INT_IDCONTROLPRESUPUESTAL);
            cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", detconpresu.EGAS_VCH_IDESPECIFICADEGASTO);
            cmd.Parameters.AddWithValue("@META_VCH_IDMETA", detconpresu.META_VCH_IDMETA);
            cmd.Parameters.AddWithValue("@DCPR_DEC_IMPORTE", detconpresu.DCPR_DEC_IMPORTE);
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
