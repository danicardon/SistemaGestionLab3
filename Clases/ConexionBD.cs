using System;
using System.Collections.Generic;
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
        private readonly string cadenaDeConexion;
        private readonly string usuario;
        //fixme
        /*
         * Aca se modifica los valores una vez implementados los cambios
         * en especial usuarioConstructor
         */
        public ConexionBD(string baseDatos, string contraseña = ""/*,string usuarioConstructor*/)
        {
            string servidor = "localhost";

            //usuario = usuarioConstructor;
            usuario = "root";

            cadenaDeConexion = $"Server={servidor};Database={baseDatos};User ID={usuario};Password={contraseña};" +
                               "Pooling=true;SslMode=none;";
        }
        public bool ValidarConexion()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base datos");
                    return true;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    string query = $"SELECT COUNT(*) FROM Usuarios WHERE nombre = @usuario AND contrasena = @contrasena ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        return resultado > 0 && resultado < 2;
                    }

                }
                catch (MySqlException e)
                {
                    Console.WriteLine($"Error al verificar el usuario: {e.Message}");
                    return false;
                }
            }
        }
        public bool AgregarUsuario(string empresa, string nombre, string apellido, string email, string contrasena, string rolID, DateTime fecha)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
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

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }

                }
                catch (MySqlException e)
                {
                    Console.WriteLine($"Error al insertar usuario: {e.Message}");
                    return false;
                }
            }
        }

        /*
         * fixme
         * Se debe modificar para que aquel usuario que tenga los permisos pueda modificar al resto
         */
        public bool EliminarUsuario(string nombre, string contrasena)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaDeConexion))
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