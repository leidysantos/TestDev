namespace TestDevBackend.Models
{
    // Clase que representa la tabla libros en la base de datos

    public class libros
    {
        public int ISBN { get; set; }
        public int editoriales_id { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string npaginas { get; set; }
    }
}
