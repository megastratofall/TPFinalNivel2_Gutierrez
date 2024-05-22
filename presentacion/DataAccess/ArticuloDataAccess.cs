using presentacion.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace presentacion.DataAccess
{
    internal class ArticuloDataAccess
    {
        private readonly DatabaseHelper _databaseHelper;

        public ArticuloDataAccess()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public List<Articulo> GetAll()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlConnection connection = null;
            SqlDataReader lector = null;

            try
            {
                connection = _databaseHelper.GetConnection();
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT A.*, M.Descripcion AS MarcaDescripcion, C.Descripcion AS CategoriaDescripcion " +
                                                    "FROM Articulos A " +
                                                    "INNER JOIN Marcas M ON A.IdMarca = M.Id " +
                                                    "INNER JOIN Categorias C ON A.IdCategoria = C.Id", connection);

                lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        Codigo = lector["Codigo"].ToString(),
                        Nombre = lector["Nombre"].ToString(),
                        Descripcion = lector["Descripcion"].ToString(),
                        Marca = lector["MarcaDescripcion"].ToString(),
                        Categoria = lector["CategoriaDescripcion"].ToString(),
                        ImagenUrl = lector["ImagenUrl"].ToString(),
                        Precio = (decimal)lector["Precio"]
                    };
                    articulos.Add(articulo);
                }

                lector.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");

                if (lector != null && !lector.IsClosed)
                {
                    lector.Close();
                }
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return articulos;
        }
    }
}
