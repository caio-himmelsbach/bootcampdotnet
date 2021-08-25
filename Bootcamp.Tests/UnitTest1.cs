using Bootcamp.Borders.DTO.Aluno;
using Bootcamp.Borders.Entities;
using Bootcamp.Borders.Repository.Aluno;
using Bootcamp.Borders.UseCase;
using Bootcamp.Borders.UseCase.Aluno;
using Bootcamp.UseCase.Aluno;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Bootcamp.Tests
{
    public class AlunoTest
    {
        [Fact]
        public void GetAlunoWhenExists()
        {
            //Arrange
            Mock<IAlunoRepository> alunoRepository = new Mock<IAlunoRepository>();
            IUseCase<GetAlunoRequest, Borders.Entities.Aluno> alunoUseCase = new GetAlunoUseCase(alunoRepository.Object);

            GetAlunoRequest alunoRequest = new GetAlunoRequest()
            {
                AlunoId = 1
            };

            IList<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno { CPF = "472893472", Id = 1, Matricula = "43829748293", Nome = "Caio" });
            alunos.Add(new Aluno { CPF = "472893472", Id = 2, Matricula = "43829748293", Nome = "Gustavo" });
            alunos.Add(new Aluno { CPF = "472893472", Id = 3, Matricula = "43829748293", Nome = "Mauricio" });
            alunos.Add(new Aluno { CPF = "472893472", Id = 4, Matricula = "43829748293", Nome = "Frederico" });
            alunos.Add(new Aluno { CPF = "472893472", Id = 5, Matricula = "43829748293", Nome = "Diogo" });

            alunoRepository.Setup(x => x.GetAll()).Returns(alunos);

            // Act
            var alunoResponse = alunoUseCase.Execute(alunoRequest);

            // Assert
            Assert.True(alunoResponse.Id == alunoRequest.AlunoId);
        }
    }
}
