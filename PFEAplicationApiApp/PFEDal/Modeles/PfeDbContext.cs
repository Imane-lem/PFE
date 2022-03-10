using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
   public class PfeDbContext:DbContext
    {
        public PfeDbContext(DbContextOptions<PfeDbContext> options) : base(options)
        {

        }
       
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Command_Entree> Command_Entrees { get; set; }
        public DbSet<Commande_Sortie> Commande_Sorties { get;}
        public DbSet<Facture> factures { get; set; }
        public DbSet<Fournisseur> fournisseurs { get; set; }
        public DbSet<Lig_Com_Entree> Lig_Com_Entrees { get; set;}
        public DbSet<Lig_Com_Sortie> Lig_Com_Sorties { get; set; }
        public DbSet<Liv_Entree> liv_Entrees { get; set; }
        public DbSet<Liv_Sortie> liv_Sorties { get;set; }
        public DbSet<Session> Sessions { get;set; }
        public DbSet<Utilisateur> Utilisateurs { get;set; }

    }
}
