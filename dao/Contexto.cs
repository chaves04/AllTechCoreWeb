using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace AllTechCoreWeb.dao
{
    public class Contexto : DbContext
    {
        public DbSet<Models.Cadastro> Cadastro { get; set; }
        
        public Contexto( DbContextOptions<Contexto> opcao): base( opcao )
        {

        }

    }
}
