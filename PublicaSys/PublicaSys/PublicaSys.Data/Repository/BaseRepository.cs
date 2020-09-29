using System;
using PublicaSys.Data.Context;
using PublicaSys.Domain.Entities;
using PublicaSys.Domain.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicaSys.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : Base
    {
        public List<T> ListAll()
        {
            List<T> list;
            using (PublicaSysContext context = new PublicaSysContext())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }

        public T GetById(int id)
        {
            T model;
            using (PublicaSysContext context = new PublicaSysContext())
            {
                model = context.Set<T>().Find(id);
                
            }
            return model;

        }
        public string Create(T model)
        {
            using (PublicaSysContext context = new PublicaSysContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
            return "Inserido com sucesso";

        }
        public string Update(T model)
        {
            using (PublicaSysContext context = new PublicaSysContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado com sucesso";
        }
        public string Delete(int id)
        {
            using (PublicaSysContext context = new PublicaSysContext())
            {
                T model = GetById(id);
                context.Entry<T>(model).State = EntityState.Deleted;
                context.Set<T>().Remove(model);
                context.SaveChanges();
            }
            return "Deletado com sucesso";
        }

    }
}