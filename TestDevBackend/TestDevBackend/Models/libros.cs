namespace TestDevBackend.Models
{
    public class libros
    {
        public int ISBN { get; set; }
        public int editoriales_id { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string npaginas { get; set; }
    }
}
