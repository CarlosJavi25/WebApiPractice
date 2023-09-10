using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiPractice.Models;

public partial class PracticaDbContext : DbContext
{
    public PracticaDbContext()
    {
    }

    public PracticaDbContext(DbContextOptions<PracticaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    


    
}
