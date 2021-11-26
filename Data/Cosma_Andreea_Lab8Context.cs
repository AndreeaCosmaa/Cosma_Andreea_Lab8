using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cosma_Andreea_Lab8.Models;

namespace Cosma_Andreea_Lab8.Data
{
    public class Cosma_Andreea_Lab8Context : DbContext
    {
        public Cosma_Andreea_Lab8Context (DbContextOptions<Cosma_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cosma_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cosma_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cosma_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
