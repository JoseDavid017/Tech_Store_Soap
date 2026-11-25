using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechStoreServidor
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtProductID.Text);

                // Crear el cliente del servicio SOAP
                TechStoreServidor.TechStoreServer servicio = new TechStoreServidor.TechStoreServer();

                // Consumir el método SOAP
                var producto = servicio.ConsultarProductos(id);

                if (producto != null)
                {
                    lblNombre.Text = producto.ProductName;
                    lblPrecio.Text = producto.Price.ToString();
                    lblStock.Text = producto.StockQuantity.ToString();

                    lblResultado.Text = "Producto encontrado";
                    lblResultado.CssClass = "text-success";
                }
                else
                {
                    lblResultado.Text = "Producto no encontrado";

                    lblNombre.Text = "";
                    lblPrecio.Text = "";
                    lblStock.Text = "";
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Introduce un ID válido.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            { int id = Convert.ToInt32(txtProductID.Text);
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string categoria = txtCategoria.Text;
                int stock = Convert.ToInt32(txtStock.Text);
                // Crear el cliente del servicio SOAP
                TechStoreServidor.TechStoreServer servicio = new TechStoreServidor.TechStoreServer();
                // Consumir el método SOAP
                var producto = servicio.RegistrarProducto(nombre, precio, categoria, stock);
                if (producto != null)
                {
                    lblResultadoRegistrar.Text = "Producto registrado con éxito";
                    lblResultadoRegistrar.CssClass = "text-success";
                }
                else
                {
                    lblResultadoRegistrar.Text = "Error al registrar el producto";
                    lblResultadoRegistrar.CssClass = "text-danger";
                }
            }
            catch (FormatException)
            {
                lblResultadoRegistrar.Text = "Introduce valores válidos.";
            }
            catch (Exception ex)
            {
                lblResultadoRegistrar.Text = "Error: " + ex.Message;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try 
            { 
                int id = Convert.ToInt32(txtActualizarID.Text);
                string nombre = txtActualizarNombre.Text;
                decimal precio = Convert.ToDecimal(txtActualizarPrecio.Text);
                string categoria = txtActualizarCategoria.Text;
                int stock = Convert.ToInt32(txtActualizarStock.Text);
                // Crear el cliente del servicio SOAP
                TechStoreServidor.TechStoreServer servicio = new TechStoreServidor.TechStoreServer();
                // Consumir el método SOAP
                var producto = servicio.ActualizarProducto(id, nombre, precio, categoria, stock);
                if(producto != null)
                {
                    lblResultadoActualizar.Text = "Producto actualizado con éxito";
                    lblResultadoActualizar.CssClass = "text-success";
                }
                else
                {
                    lblResultadoActualizar.Text = "Error al actualizar el producto";
                    lblResultadoActualizar.CssClass = "text-danger";
                }
            }
            catch (FormatException)
            {
                lblResultadoActualizar.Text = "Introduce valores válidos.";
            }
            catch (Exception ex)
            {
                lblResultadoActualizar.Text = "Error: " + ex.Message;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtEliminarID.Text);
                // Crear el cliente del servicio SOAP
                TechStoreServidor.TechStoreServer servicio = new TechStoreServidor.TechStoreServer();
                // Consumir el método SOAP
                var producto = servicio.EliminarProducto(id);
                if (producto != null)
                {
                    lblResultadoEliminar.Text = "Producto eliminado con éxito";
                    lblResultadoEliminar.CssClass = "text-success";
                }
                else
                {
                    lblResultadoEliminar.Text = "Error al eliminar el producto";
                    lblResultadoEliminar.CssClass = "text-danger";
                }

            }
            catch (FormatException)
            {
                lblResultadoEliminar.Text = "Introduce un ID válido.";
            }
            catch (Exception ex)
            {
                lblResultadoEliminar.Text = "Error: " + ex.Message;
            }
        }
    }
}