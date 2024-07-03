using WebApplication1.Models;

namespace WebApplication1.Servicio
{
    public interface IRepositorioProyectos
    {
        public IEnumerable<Proyecto> ObtenerProyectos();
    }
}
