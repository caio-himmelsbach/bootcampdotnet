using Bootcamp.Borders.DTO.Aluno;
using Bootcamp.Borders.Repository.Aluno;
using Bootcamp.Borders.UseCase.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.UseCase.Aluno
{
    public class GetAlunoUseCase : IGetAlunoUseCase
    {
        private readonly IAlunoRepository alunoRepository;
        public GetAlunoUseCase(IAlunoRepository alunoRepository)
        {
            this.alunoRepository = alunoRepository;
        }

        public Borders.Entities.Aluno Execute(GetAlunoRequest request)
        {
            var alunos = alunoRepository.GetAll();
            return alunos.FirstOrDefault();
        }
    }
}
