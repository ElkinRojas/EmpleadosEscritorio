using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosEscritorio2.datos
{
    internal class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            con = new SqlConnection("Server=DESKTOP-MS73491;Database=empleado_bd;Integrated security=true");
        }

        public SqlConnection conectar()
        {
            try
            { 
                con.Open();
                return con;
            } catch (Exception ex)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
