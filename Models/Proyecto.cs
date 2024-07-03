namespace WebApplication1.Models
{
    public class Proyecto
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }
        public string Link { get; set; }

        public Proyecto(string titulo, string descripcion, string imagen, string link)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.ImagenURL = imagen;
            this.Link = link;
        }
    }
}
