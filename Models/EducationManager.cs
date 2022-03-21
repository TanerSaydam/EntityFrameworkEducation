using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEducation.Models
{
    public class EducationManager : IEducationService
    {
        public List<Education> GetAll()
        {
            using (var context = new ContextDb())
            {
                return context.Educations.ToList();
            }
        }
    }
}
