using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using presentacion.BusinessLogic;
using presentacion.Models;

namespace presentacion.Controllers
{
    internal class ArticuloController
    {
        private readonly ArticuloBusiness _articuloBusiness;

        public ArticuloController()
        {
            _articuloBusiness = new ArticuloBusiness();
        }

        public List<Articulo> ObtenerTodosLosArticulos()
        {
            return _articuloBusiness.ObtenerTodosLosArticulos();
        }
    }
}
