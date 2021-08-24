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
        public BootcampDbContext()
        {

        }

        public DbSet<Borders.Entities.Aluno> Alunos { get; set; }
    }
}
