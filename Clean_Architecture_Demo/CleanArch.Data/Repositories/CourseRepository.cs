using CleanArch.Data.Interfaces;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SQLDBContext _sqlDBContext;
        public CourseRepository(SQLDBContext sqlDBContext)
        {
            _sqlDBContext = sqlDBContext;
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await _sqlDBContext.Set<Course>().AsNoTracking().ToListAsync();
        }
    }
}
