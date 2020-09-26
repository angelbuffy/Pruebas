using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Farmacia_Final
{
    public class Farmaceutico
    {

        private string _DNI;
        private string _Nombres;
        private string _ApellidoPaterno;
        private string _ApellidoMaterno;
        private string _Direccion;
        private string _Profesion;
        
        public Farmaceutico(string DNI1, string Nom, string ApePat, string
             ApeMat, string Direc, string Prof)
        {
            DNI = DNI1;
            Nombres = Nom;
            ApellidoPaterno = ApePat;
            ApellidoMaterno = ApeMat;
            Direccion = Direc;
            Profesion = Prof;

        }
        public string DNI
        {
            get
            {
                return _DNI;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El número de DNI no puede quedar vacío.");
                }
                else if (value.Trim().Length > 8)
                {
                    throw new ArgumentOutOfRangeException("El número de DNI tiene un formato inválido.");
                }
                else
                {
                    _DNI = value.Trim();
                }
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del nombre no puede quedar vacío.");
                }
                
                else
                {
                    _Nombres = value.Trim();
                }
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return _ApellidoPaterno;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido paterno no puede quedar vacío.");
                }
                
                else
                {
                    _ApellidoPaterno = value.Trim();
                }
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return _ApellidoMaterno;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido materno no puede quedar vacío.");
                }
                
                else
                {
                    _ApellidoMaterno = value.Trim();
                }
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la direccion no puede quedar vacío.");
                }
                
                else
                {
                    _Direccion = value.Trim();
                }
            }
        }

        public string Profesion
        {
            get
            {
                return _Profesion;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la profesion no puede quedar vacío.");
                }
                
                else
                {
                    _Profesion = value.Trim();
                }
            }
        }

        public void Registrar()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("usp_Insertar_Farmaceuticos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", DNI);
            comando.Parameters.AddWithValue("@Nombres", Nombres);
            comando.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
            comando.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Profesion", Profesion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}

