using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Farmacia_Final
{
    public class Login
    {
        private string _usuario;
        private string _contrase;

        public Login (string usu, string contra)
            {
            Usuario = usu;
            Contrase = contra;
            }

        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del usuario no puede quedar vacío.");
                }

                {
                    _usuario = value.Trim();
                }
            }
        }

        public string Contrase
        {
            get
            {
                return _contrase;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la contraseña no puede quedar vacío.");
                }

                {
                    _contrase = value.Trim();
                }
            }
        }


        public static Login Validar(string argUsuario,string argContrasenia)
        {
            Login x = null;

            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("ValidacionUsuario02", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", argUsuario);
            comando.Parameters.AddWithValue("@contra", argContrasenia);
            conexion.Open();
            SqlDataReader contendor= comando.ExecuteReader();

            while (contendor.Read()==true)
            {
                x = new Login(contendor["usuario"].ToString(),"contra");
            }
            conexion.Close();
            conexion.Dispose();
            return x;
        }

    }
}
