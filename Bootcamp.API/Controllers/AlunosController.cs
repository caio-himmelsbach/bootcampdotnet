using Bootcamp.Borders.DTO.Aluno;
using Bootcamp.Borders.Entities;
using Bootcamp.Borders.UseCase.Aluno;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunosController : Controller
    {
        private IGetAlunoUseCase getAlunoUseCase;
        public AlunosController(IGetAlunoUseCase getAlunoUseCase)
        {
            this.getAlunoUseCase = getAlunoUseCase;
        }

        [HttpGet]
        public Aluno Get([FromQuery]GetAlunoRequest request)
        {
            return getAlunoUseCase.Execute();
        }
    }
}
