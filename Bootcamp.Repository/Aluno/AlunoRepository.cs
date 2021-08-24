using Bootcamp.Borders.DTO.Aluno;
using Bootcamp.Borders.Repository.Aluno;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Repository.Aluno
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly IList<Borders.Entities.Aluno> alunos;
        private readonly BootcampDbContext dbContext;
        public AlunoRepository(DbContext dbContext)
        {
            this.dbContext = dbContext as BootcampDbContext;
        }
        public IEnumerable<Borders.Entities.Aluno> GetAll()
        {
            return dbContext.Alunos.ToList();
        }

        public Borders.Entities.Aluno GetById(GetAlunoRequest request)
        {
            return dbContext.Alunos.Where(x => x.Id == request.AlunoId).FirstOrDefault();
        }
    }
}
