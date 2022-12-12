using Dapper.Contrib.Extensions;

namespace Blog.Modelo{

    [Table("Usuario")]

    public class Usuario{
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
    }
}