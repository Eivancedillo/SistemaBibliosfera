using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorPermisos
    {
        Base b = new Base();

        public bool ComprobarPermiso(int acceso, int permiso, int administrador)
        {
            // Comprobar si el usuario tiene el permiso
            DataRow dr = b.Consultar($"call p_consultar_permiso({acceso}, {permiso}, {administrador})", "permisos").Tables[0].Rows[0];

            if (dr["rs"].ToString().Equals("Aceptado"))
                return true;
            else
                return false;
        }

        public bool ComprobarAcceso(int idacceso, int administrador)
        {
            // Comprobar si el usuario tiene el acceso
            DataRow dr = b.Consultar($"call p_consultar_acceso({idacceso}, {administrador})", "accesos").Tables[0].Rows[0];

            if (dr["rs"].ToString().Equals("Aceptado"))
                return true;
            else
                return false;
        }
    }
}
