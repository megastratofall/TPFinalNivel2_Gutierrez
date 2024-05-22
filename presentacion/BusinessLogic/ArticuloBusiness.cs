using presentacion.DataAccess;
using presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace presentacion.BusinessLogic
{
    internal class ArticuloBusiness
    {
            private readonly ArticuloDataAccess _articuloDataAccess;

            public ArticuloBusiness()
            {
                _articuloDataAccess = new ArticuloDataAccess();
            }

            public List<Articulo> ObtenerTodosLosArticulos()
            {
                return _articuloDataAccess.GetAll();
            }

        }
    }
