using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiClientes.Models;

namespace WebApiClientes.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options){

        }
        public DbSet<Clientes> Clientes { get; set; }
    }
}