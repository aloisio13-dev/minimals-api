using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.infraestrutura.Db;

public class DbContexto : DbContext
{
       


    {  
         private readonly IConfiguration_configuracaoAppSettings;

        public DbContexto(IConfiguration_configuracaoAppSettings)   
        {
          _configuracaoAppSettings = configuracaoAppSettings;

        }


       public DbSet<Administrador> Administradores { get; set; } = default!;

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {

           if(!optionsBuilder.IsConfigured)   
           {
              var stringConexao = _configuracaoAppSettings.GetConnectionString("sql")?.ToString();
              if (!string.IsNullOrEmpty(stringConexao))
               {
                 optionsBuilder.UseSql(stringconexão,ServerVersion.AutoDetect(stringconexão)
               } 
           }   
       }    

    }
}

    
