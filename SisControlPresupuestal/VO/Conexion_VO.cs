using System;

public class BEConexion
{
    public static string _cadenaconexion = "Data Source=localhost;Initial Catalog=SISCONTROLPRESUPUESTAL;Integrated Security=True";

    public static string cadenaconexion
    {
        get { return _cadenaconexion; } 
    }
}
