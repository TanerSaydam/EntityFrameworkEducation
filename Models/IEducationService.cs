using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEducation.Models
{
    public interface IEducationService
    {
        List<Education> GetAll();
    }
}
