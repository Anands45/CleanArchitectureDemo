using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Data.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetCourses();
    }
}
