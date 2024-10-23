using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Need4Sprint.Clases
{

    internal class ConexionBD
    {

        private MySqlConnection conexion;
        //readonly para que los valores se apliquen una vez y no se puedan modificar mas adelante
        private readonly string cadenaConexion;

        //Constructor donde se define la cadena de conexion y se le asigna a conexion
        public ConexionBD(string usuario, string contraseña)
        {
            cadenaConexion = $"server=localhost;user={usuario};password={contraseña};database=sistema_gestion_empresarial;";
            conexion = new MySqlConnection(cadenaConexion) ;
        }

        //Metodo para abrir la conexion a la bd
        private bool AbrirConexion()
        {
            try
            {
                if(conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al abrir la conexion:"+e.Message);
            }
            return false;
        }
        //Metodo para cerrar la conexion a la bd
        private void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open) conexion.Close();
        }

        //Metodo para login, valida que en la base de datos haya coinsidencia con el usuario ingresado y la contraseña
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            using (conexion)
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Usuarios WHERE nombre = @usuario AND contrasena = @contrasena";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        //Se utiliza injección de tados para evitar vulnerabilidades
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        if (AbrirConexion())
                        {
                            int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                            return resultado > 0 && resultado < 2;
                        }
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine($"Error al verificar el usuario: {e.Message}");
                }
            }
            return false;
        }

        //fixme
        //Falta validar el rol_id y la empresa
        public bool AgregarUsuario(int empresa, string nombre, string apellido, string email, string contrasena, int rolID, DateTime fecha)
        {
            using (conexion)
            {
                try
                {
                    string query = @"INSERT INTO usuarios (empresa, nombre, apellido, email, contraseña, rol_id, fecha_registro) 
                        VALUES (@empresa, @nombre, @apellido, @email, @contrasena, @rolID, @fecha);"
                    ;

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@empresa", empresa);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@rolID", rolID);
                        cmd.Parameters.AddWithValue("@fecha", fecha);


                        if (AbrirConexion())
                        {
                            int filasAfectadas = cmd.ExecuteNonQuery(); 
                            return filasAfectadas > 0;
                        }
                    }

                }
                catch (MySqlException e)
                {
                    Console.WriteLine($"Error al insertar usuario: {e.Message}");
                }
            }
            return false;
        }

        /*
         * fixme
         * Se debe modificar para que aquel usuario que tenga los permisos pueda modificar al resto
         */
        public bool EliminarUsuario(string nombre, string contrasena)
        {
            using (conexion)
            {
                try
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE nombre = @nombre AND contrasena = @contrasena;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }


                }
                catch (MySqlException e)
                {
                    return false;
                }
            }
        }



    }

}