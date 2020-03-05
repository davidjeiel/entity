using ALURA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALURA.DAO
{
    public class BlogDAO
    {
        public void Adiciona(Blogs blog)
        {
            using (var context = new ModelContexto())
            {
                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        public IList<Blogs> Lista()
        {
            using (var context = new ModelContexto())
            {
                return context.Blogs.ToList();
            }
        }

        public Blogs BuscarPorId(int id)
        {
            using (var context = new ModelContexto())
            {
                return context.Blogs.Find(id);
            }
        }

        public void Atualiza(Blogs blog)
        {
            using (var context = new ModelContexto())
            {
                context.Entry(blog).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}