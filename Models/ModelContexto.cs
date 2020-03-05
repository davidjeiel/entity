namespace ALURA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContexto : DbContext
    {
        public ModelContexto()
            : base("name=ModelContexto")
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
