using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentacion.Controllers;
using presentacion.Models;

namespace presentacion
{
    public partial class ArticulosForm : Form
    {
        private readonly ArticuloController _articuloController;

        public ArticulosForm()
        {
            InitializeComponent();
            _articuloController = new ArticuloController();
        }

        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            List<Articulo> articulos = _articuloController.ObtenerTodosLosArticulos();
            dgvArticulos.DataSource = articulos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un artículo
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Lógica para modificar un artículo
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un artículo
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Lógica para buscar artículos
        }
    }
}
