using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Producto";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }


            }
            catch (Exception)
            {

            }
            return dt;

        }

        public async Task<bool> InsertarAsync(Producto Producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO Producto VALUES (@Codigo, @Descripcion, @Existencia, @Precio, @FechaCreacion, @Imagen);";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Coigo", MySqlDbType.Int32, 20).Value = Producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 50).Value = Producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = Producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.DateTime).Value = Producto.Precio;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.Decimal).Value = Producto.FechaCreacion;
                        comando.Parameters.Add("@Imagen", MySqlDbType.LongBlob).Value = Producto.Imagen;

                        await comando.ExecuteNonQueryAsync();
                        inserto = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return inserto;
        }

        public async Task<bool> ActualizarAsync(Producto Producto)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE Producto SET Descripcion=@Descripcion, Existencia=@Existencia, Precio=@Preci, Creacion=@Creacion, Imagen=@Imagen WHERE Codigo=@Codigo; ";


                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Coigo", MySqlDbType.Int32, 20).Value = Producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 50).Value = Producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = Producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.DateTime).Value = Producto.Precio;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.Decimal).Value = Producto.FechaCreacion;
                        comando.Parameters.Add("@Imagen", MySqlDbType.LongBlob).Value = Producto.Imagen;

                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return actualizo;
        }

        public async Task<bool> EliminarAsync(string codigo)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM Producto Where Codigo = @Codigo;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Coigo", MySqlDbType.Int32).Value = codigo;
                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return elimino;
        }

        public async Task<byte[]> SeleccionarImagen(string codigo)
        {
            byte[] imagen = new byte[0];

            try
            {
                string sql = "SELECT Imagen FROM Producto Where Codigo = @Codigo;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Coigo", MySqlDbType.Int32).Value = codigo;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        if (dr.Read())
                        {
                            imagen = (byte[])dr["Imagen"];
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            return imagen;
        }

    }
}
