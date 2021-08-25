using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Borders
{
    public interface IValidator<TRequest>
    {
        void ValidateAndThrow(TRequest request);
    }
}
