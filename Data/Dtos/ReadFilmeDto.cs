using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
       
        public string titulo { get; set; }

        
        public string genero { get; set; }

         
        public int duracao { get; set; }

        
        public string sinopse { get; set; }

        public string estrelaPrincipal { get; set; }

        public DateTime horaConsulta { get; set; } = DateTime.Now;


    }
}
