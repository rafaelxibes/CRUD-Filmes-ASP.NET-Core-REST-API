using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo títilo é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório!")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não deve passar de 30 caracteres!")]
        public string Genero { get; set; }
        [Range(1, 240, ErrorMessage = "A duração deverá ter mínima de 1 minuto e máximo de 240 minutos!")]
        public int Duracao { get; set; }
    }
}
