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
    {  public DataTable getMeta()
        {
             

            DataTable mDtMeta = new DataTable();
            try
            {
                using (SqlConnection sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion))
                {
                    SqlCommand cmdComand = new SqlCommand("USP_S_SICOP_META", sqlConection);
                    cmdComand.CommandType = CommandType.StoredProcedure;
                    sqlConection.Open();
                    SqlDataAdapter mDaMeta = new SqlDataAdapter(cmdComand);
                    mDaMeta.Fill(mDtMeta);
                    return mDtMeta;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return mDtMeta;

        }
    }
}
