using Microsoft.EntityFrameworkCore;
using System;

namespace CleanArch.Data
{
    public class SQLDBContext : DbContext
    {

        public SQLDBContext(DbContextOptions<SQLDBContext> options) : base(options)
        {

        }
        


    }
}
