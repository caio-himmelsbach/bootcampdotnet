using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Borders.DTO.Aluno
{
    public class CreateAlunoResponse
    {
        public Borders.Entities.Aluno Aluno { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Message { get; set; }
    }
}
