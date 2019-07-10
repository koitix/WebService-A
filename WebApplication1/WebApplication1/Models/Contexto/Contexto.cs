using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Classes;

namespace WebApplication1.Models.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> contexto) : base(contexto)
        {
            Database.EnsureCreated();
        }

        public DbSet<Sala> sala{get;set;}
    }
}
