using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesenvolvedorIoDemoMVC.Models
{
    public class Filme
    {
        // Indica que esta propriedade é chave primária
        [Key]
        public int Id { get; set; }

        // Este campo passa a ser obrigatório e fará parte da validação da model
        [Required(ErrorMessage = "O campo título é obrigatório")]

        // Validando o tamnho do título
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do título deve estar entre 3 e 60 caracteres")]
        public string Titulo { get; set; }

        // Validando o tipo de dados
        [DataType(DataType.DateTime, ErrorMessage = "A data não está no formato correto")]

        // Alterando o nome da propriedadeque para exibição na tela
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; }

        //Definindo um intervalo que será aceito pela propriedade
        [Range(1, 1000)]

        //Definindo o tipo desta propriedade no BD
        [Column(TypeName = "decimal(12,8)")]
        public decimal Valor { get; set; }

        public int Avaliacao { get; set; }
    }
}
