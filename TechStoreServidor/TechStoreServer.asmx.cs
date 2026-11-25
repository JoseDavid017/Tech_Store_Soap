using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TechStoreServidor
{
    /// <summary>
    /// Descripción breve de TechStoreServer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class TechStoreServer : System.Web.Services.WebService
    {

        [WebMethod]
        public Products ConsultarProductos(int productId)
        {
            string conexion = ConfigurationManager.ConnectionStrings["TechStore"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Products producto = new Products();

                            producto.ProductID = (int)reader["ProductID"];
                            producto.ProductName = reader["ProductName"].ToString();
                            producto.Category = reader["Category"].ToString();
                            producto.Price = (decimal)reader["Price"];
                            producto.StockQuantity = (int)reader["StockQuantity"];

                            return producto;
                        }
                        else
                        {
                            return null; // No se encontró el producto
                        }
                    }
                }
            }
        }
        [WebMethod]
        public Products RegistrarProducto(string productName, decimal price,string Category, int stockQuantity)
        {
            string conexion = ConfigurationManager.ConnectionStrings["TechStore"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                string query = "INSERT INTO PRODUCTS (ProductName, Category, Price, StockQuantity) OUTPUT INSERTED.ProductID VALUES (@ProductName, @Category, @Price, @StockQuantity)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Category", Category);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                    int insertedProductId = (int)cmd.ExecuteScalar();
                    Products producto = new Products
                    {
                        ProductID = insertedProductId,
                        ProductName = productName,
                        Category = Category,
                        Price = price,
                        StockQuantity = stockQuantity
                    };
                    return producto;
                }
            }
        }
        [WebMethod]
        public Products ActualizarProducto(int productId, string productName, decimal price, string category, int stockQuantity)
        {
            string conexion = ConfigurationManager.ConnectionStrings["TechStore"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                string query = "UPDATE PRODUCTS SET ProductName = @ProductName, Category = @Category, Price = @Price, StockQuantity = @StockQuantity WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return new Products
                        {
                            ProductID = productId,
                            ProductName = productName,
                            Category = category,
                            Price = price,
                            StockQuantity = stockQuantity
                        };
                    }
                    else
                    {
                        return null; // No se encontró el producto para actualizar
                    }
                }
            }
        }
        [WebMethod]
        public Products EliminarProducto(int productId)
        {
            string conexion = ConfigurationManager.ConnectionStrings["TechStore"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                string query = "DELETE FROM PRODUCTS WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return new Products { ProductID = productId }; // Retorna el ID del producto eliminado
                    }
                    else
                    {
                        return null; // No se encontró el producto para eliminar
                    }
                }
            }
        }

        public class Products
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
        }
    }
}
