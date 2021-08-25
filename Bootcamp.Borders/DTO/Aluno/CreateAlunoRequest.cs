using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Borders.DTO.Aluno
{
    public class CreateAlunoRequest
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Matricula { get; set; }
    }
}
