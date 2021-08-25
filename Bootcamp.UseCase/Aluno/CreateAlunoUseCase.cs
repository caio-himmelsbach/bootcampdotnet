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
    public class CreateAlunoUseCase : ICreateAlunoUseCase
    {
        private readonly IAlunoRepository repository;
        public CreateAlunoUseCase(IAlunoRepository repository)
        {
            this.repository = repository;
        }
        public Borders.Entities.Aluno Execute(CreateAlunoRequest request)
        {
            Borders.Entities.Aluno aluno = new Borders.Entities.Aluno
            {
                CPF = request.CPF,
                Matricula = request.Matricula,
                Nome = request.Nome
            };


            return repository.Create(aluno);
        }
    }
}
