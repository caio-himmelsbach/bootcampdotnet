using Bootcamp.Borders.DTO.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Borders.Repository.Aluno
{
    public interface IAlunoRepository : IRepository<Entities.Aluno>
    {
        Borders.Entities.Aluno GetById(GetAlunoRequest request);
    }
}
