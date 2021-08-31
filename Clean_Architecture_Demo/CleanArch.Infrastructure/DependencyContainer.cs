using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Data.Interfaces;
using CleanArch.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.InfraStructure
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddTransient<ICourseService, CourseService>();


            //Data Layer
            services.AddTransient<ICourseRepository, CourseRepository>();
        }
    }
}
