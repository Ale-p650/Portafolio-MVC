using WebApplication1.Models;

namespace WebApplication1.Servicio
{
    public class RepositorioProyecto : IRepositorioProyectos
    {
        public IEnumerable<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> {

                new Proyecto("Reddit",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                "/Imagenes/reddit.jpg", "https://www.reddit.com"),

                new Proyecto("Amazon","Libero nunc consequat interdum varius",
                "/Imagenes/amazon.jpg","https://www.amazon.com/-/es/"),

                new Proyecto("Youtube",
                "Ultricies integer quis auctor elit sed. Auctor neque vitae" +
                " tempus quam pellentesque nec.","/Imagenes/youtube.jpg","https://youtube.com")

            };
        }
    }
}
