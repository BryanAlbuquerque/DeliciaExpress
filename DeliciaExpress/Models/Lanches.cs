using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeliciaExpress.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(80, MinimumLength = 5, ErrorMessage = "O {0} Deve ter o minimo {1} e no maximo {2} Caracteres")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descrição deve ser informada")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição Deve ter no maximo {1} Caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição Deve ter no maximo {1} Caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição deve ser informada")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição Deve ter no maximo {1} Caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição Deve ter no maximo {1} Caracteres")]
        public string DescricaoLonga { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem")]
        [StringLength(200, ErrorMessage = "O {0} deve ter o maximo de {1} Caracteres!")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter o maximo de {1} Caracteres!")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }


        // foreign Key e relacionamentos
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
