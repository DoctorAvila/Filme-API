using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    //Utilizar data anotations para restringir os campos

    [Key]
    [Required]
    public int Id { get; set; }
   

    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    [MaxLength(60, ErrorMessage = "O tamanho do titulo permitido não deve exceder 50 caracteres")]
    public string titulo { get; set; }

    [Required(ErrorMessage = "O genêro do filme é obrigatório")]
    [MaxLength(50, ErrorMessage ="O tamanho do genêro permitido não deve exceder 50 caracteres")]
    public string genero { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A duração não deve passar de 600 minutos")]
    public int duracao { get; set; }

    [Required]
    [MaxLength(200, ErrorMessage = "A sinopse não deve exceder os 200 caracteres")]
    public string sinopse { get; set; }


    [Required]
    [MaxLength(100, ErrorMessage ="O nome do ator não pode exceder 100 caracteres")]
    public string estrelaPrincipal { get; set; }



}
