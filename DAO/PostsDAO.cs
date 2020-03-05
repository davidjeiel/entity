using ALURA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALURA.DAO
{
    public class PostsDAO
    {
        public void Adiciona(Posts post)
        {
            using (var context = new ModelContexto())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public IList<Posts> Lista()
        {
            using(var context = new ModelContexto())
            {
                return context.Posts.ToList();
            }
        }

        public Posts BuscaPorId(int id)
        {
            using (var context = new ModelContexto())
            {
                return context.Posts.Find(id);
            }
        }

        public void Atualiza(Posts post)
        {
            using (var context = new ModelContexto())
            {
                context.Entry(post).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}