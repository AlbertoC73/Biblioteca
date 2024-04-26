using Microsoft.AspNetCore.Mvc.Rendering;
using Biblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.AccesoDatos.Repositorio.IRepositorio
{
    public interface IProductoRepositorio : IRepositorio<Producto>
    {
        void Actualizar(Producto producto);
        IEnumerable<SelectListItem> ObtenerTodosDropDownList(string obj);
    }
}
