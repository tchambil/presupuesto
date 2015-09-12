using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace DAL
{
    public class CONEXION_DAL
    {
        public void EstablecerConexion(string conexion)
        {
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            //XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            
            XmlDoc.Load(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[1].Value = conexion;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath);
            
        }

        public List<string> LeerConexion()
        {
            string dataSource = string.Empty;
            string integratedSecurity = string.Empty;
            string initialCatalog = string.Empty;
            string user = string.Empty;
            string password = string.Empty;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationManager.RefreshSection("connectionStrings");      
            string[] parametros = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString.Split(';');
            List<string> conexionBD = new List<string>();
            string[] ds = new string[2];
            string[] ise = new string[2];
            string[] ic = new string[2];
            string[] us = new string[2];
            string[] pw = new string[2];
            if (parametros.Length < 4)
            {
               
                ds = parametros[0].Split('=');
                dataSource = ds[1];
                ise = parametros[1].Split('=');
                integratedSecurity = ise[1];
                ic = parametros[2].Split('=');
                initialCatalog = ic[1];
                conexionBD.Add(dataSource);
                conexionBD.Add(integratedSecurity);
                conexionBD.Add(initialCatalog);
                
                return conexionBD;
            }
            else
            {
                ds = parametros[0].Split('=');
                dataSource = ds[1];
                ic = parametros[1].Split('=');
                initialCatalog = ic[1];
                us = parametros[2].Split('=');
                user = us[1];
                pw = parametros[3].Split('=');
                password = pw[1];
                conexionBD.Add(dataSource);
                conexionBD.Add(initialCatalog);
                conexionBD.Add(user);
                conexionBD.Add(password);
                return conexionBD;
            }
           
        }
        

        public SqlConnection getConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
        }
    }
}
