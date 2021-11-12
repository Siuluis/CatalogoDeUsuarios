using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CatalogoDeUsuarios
{
    class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bd_catalogos;Data Source=DESKTOP-86U7HMC");

        public void InsertUsuario(Usuario usuario)
        {
            try
            {
                conn.Open();
                string query = @"
                        INSERT INTO 
                        tca_usuario(usu_clave, usu_claveusuario, usu_nombre, usu_unidad_presupuestal, usu_telempresa, usu_telpersonal, usu_corrinstitucional, usu_corrpersonal)
                        VALUES (@Clave, @ClaveUsuario, @Nombre, @UnidadPresupuestal, @TelEmpresa, @TelPersonal, @CorreoInstitucional, @CorreoPersonal);";

                SqlParameter clave = new SqlParameter("@Clave", usuario.Clave);
                SqlParameter claveUsuario = new SqlParameter("@ClaveUsuario", usuario.ClaveUsuario);
                SqlParameter nombre = new SqlParameter("@Nombre", usuario.Nombre);
                SqlParameter unidadPresupuestal = new SqlParameter("@UnidadPresupuestal", usuario.UnidadPresupuestal);
                SqlParameter telEmpresa = new SqlParameter("@TelEmpresa", usuario.TelEmpresa);
                SqlParameter telPersonal = new SqlParameter("@TelPersonal", usuario.TelPersonal);
                SqlParameter correoInstitucional = new SqlParameter("@CorreoInstitucional", usuario.CorreoInstitucional);
                SqlParameter correoPersonal = new SqlParameter("@CorreoPersonal", usuario.CorreoPersonal);


                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(clave);
                command.Parameters.Add(claveUsuario);
                command.Parameters.Add(nombre);
                command.Parameters.Add(unidadPresupuestal);
                command.Parameters.Add(telEmpresa);
                command.Parameters.Add(telPersonal);
                command.Parameters.Add(correoInstitucional);
                command.Parameters.Add(correoPersonal);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public List<Usuario> GetUsuario(string buscarclave = null, string buscarnombre = null, string buscarup = null)
        {
            List<Usuario> usuario = new List<Usuario>();
            try
            {
                conn.Open();

                string query = @"SELECT * FROM tca_usuario";

                SqlCommand command = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(buscarclave) || !string.IsNullOrEmpty(buscarnombre) || !string.IsNullOrEmpty(buscarup))
                {

                    query += @" WHERE usu_claveusuario LIKE @BuscarC 
                                AND usu_nombre LIKE @BuscarN 
                                AND usu_unidad_presupuestal LIKE @BuscarT";

                    command.Parameters.Add(new SqlParameter("@BuscarC", $"%{buscarclave}%"));
                    //command.Parameters.Add(new SqlParameter("@BuscarC", $"{buscarclave}"));
                    command.Parameters.Add(new SqlParameter("@BuscarN", $"%{buscarnombre}%"));
                    //command.Parameters.Add(new SqlParameter("@BuscarN", $"{buscarnombre}"));
                    command.Parameters.Add(new SqlParameter("@BuscarT", $"%{buscarup}%"));
                    //command.Parameters.Add(new SqlParameter("@BuscarT", $"{buscarup}"));

                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuario.Add(new Usuario
                    {
                        //Id = Convert.ToInt32(reader["id"].ToString()),
                        Id = int.Parse(reader["id"].ToString()),
                        Clave = reader["usu_clave"].ToString(),
                        ClaveUsuario = reader["usu_claveusuario"].ToString(),
                        Nombre = reader["usu_nombre"].ToString(),
                        UnidadPresupuestal = reader["usu_unidad_presupuestal"].ToString(),
                        TelEmpresa = reader["usu_telempresa"].ToString(),
                        TelPersonal = reader["usu_telpersonal"].ToString(),
                        CorreoInstitucional = reader["usu_corrinstitucional"].ToString(),
                        CorreoPersonal = reader["usu_corrpersonal"].ToString()

                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            return usuario;
        }

        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE tca_usuario
                                 SET usu_clave = @Clave,
                                 usu_claveusuario = @ClaveUsuario,
                                 usu_nombre = @Nombre,
                                 usu_unidad_presupuestal = @UnidadPresupuestal,
                                 usu_telempresa = @TelEmpresa,
                                 usu_telpersonal = @TelPersonal,
                                 usu_corrinstitucional = @CorreoInstitucional,
                                 usu_corrpersonal = @CorreoPersonal
                                 WHERE id = @Id";

                SqlParameter id = new SqlParameter("@Id", usuario.Id);
                SqlParameter clave = new SqlParameter("@Clave", usuario.Clave);
                SqlParameter claveUsuario = new SqlParameter("@ClaveUsuario", usuario.ClaveUsuario);
                SqlParameter nombre = new SqlParameter("@Nombre", usuario.Nombre);
                SqlParameter up = new SqlParameter("@UnidadPresupuestal", usuario.UnidadPresupuestal);
                SqlParameter telempesa = new SqlParameter("@TelEmpresa", usuario.TelEmpresa);
                SqlParameter telpersonal = new SqlParameter("@TelPersonal", usuario.TelPersonal);
                SqlParameter corrinstitucional = new SqlParameter("@CorreoInstitucional", usuario.CorreoInstitucional);
                SqlParameter corrpersonal = new SqlParameter("@CorreoPersonal", usuario.CorreoPersonal);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(id);
                command.Parameters.Add(clave);
                command.Parameters.Add(claveUsuario);
                command.Parameters.Add(nombre);
                command.Parameters.Add(up);
                command.Parameters.Add(telempesa);
                command.Parameters.Add(telpersonal);
                command.Parameters.Add(corrinstitucional);
                command.Parameters.Add(corrpersonal);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void EliminarUsuario(int Id)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM tca_usuario WHERE id = @Id";

                SqlParameter id = new SqlParameter("@Id", Id);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public string Existe(string claveusuario = null, string nombre = null, string salida = "")
        {
            try
            {
                conn.Open();
                string query = @" SELECT COUNT(usu_claveusuario) FROM tca_usuario 
                                  WHERE usu_claveusuario = @claveusuario 
                                  OR usu_nombre = @nombre ";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@claveusuario", claveusuario);
                command.Parameters.AddWithValue("@nombre", nombre);
                //emp = command.ExecuteScalar().ToString();
                int emp = Convert.ToInt32(command.ExecuteScalar());

                //string EXISTENCIA = "";
                if (emp <= 0)
                {
                    salida = "si";
                    //EXISTENCIA = "GUARDADO ";
                    //Console.WriteLine("GUARDADO " + emp + " " + salida);
                }
                else
                {
                    salida = "no";
                    //EXISTENCIA = "YA EXISTE ";
                    //Console.WriteLine("YA EXISTE " + emp + " " + salida);
                }
                //Console.WriteLine(EXISTENCIA + emp + " " + salida);
                //Console.WriteLine(salida);

            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
            //Console.WriteLine(usu);
            return salida;

        }

    }
}
