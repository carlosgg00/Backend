namespace Backend.DTOs
{
    /* Conectar a jsonplaceholder.typicode.com/posts para obtener esa informacion y obtener esa lista de 
        elementos
    */
    public class PostDto
    {
        public int Id { get; set; }
        public int UserIUd { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
