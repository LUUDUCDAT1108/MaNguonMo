#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LUUDUCDAT_MaNguonMo.Models;

    public class MvcLUUDUCDAT_MaNguonMoContext : DbContext
    {
        public MvcLUUDUCDAT_MaNguonMoContext (DbContextOptions<MvcLUUDUCDAT_MaNguonMoContext> options)
            : base(options)
        {
        }

        public DbSet<LUUDUCDAT_MaNguonMo.Models.Movie> Movie { get; set; }

        public DbSet<LUUDUCDAT_MaNguonMo.Models.Customer> Customer { get; set; }

        public DbSet<LUUDUCDAT_MaNguonMo.Models.Employee> Employee { get; set; }

        public DbSet<LUUDUCDAT_MaNguonMo.Models.Person> Person { get; set; }

        public DbSet<LUUDUCDAT_MaNguonMo.Models.Student> Student { get; set; }
    }
