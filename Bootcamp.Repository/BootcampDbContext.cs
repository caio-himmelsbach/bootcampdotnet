using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Repository
{
    public class BootcampDbContext : DbContext
    {
        public BootcampDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<Borders.Entities.Aluno> Alunos { get; set; }
        public DbSet<Borders.Entities.Curso> Curso { get; set; }

    }
}
