using Bootcamp.Borders.DTO.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Borders.UseCase.Aluno
{
    public interface ICreateAlunoUseCase : IUseCase<CreateAlunoRequest, Borders.Entities.Aluno>
    {
    }
}
