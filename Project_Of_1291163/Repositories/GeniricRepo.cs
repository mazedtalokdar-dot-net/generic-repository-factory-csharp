using Project_Of_1291163.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Of_1291163.Repositories
{
    public class GeniricRepo<T> : IRepo<T> where T : CommonFeild
    {
        private readonly IList<T> _list;
        public GeniricRepo()
        {
            _list = new List<T>();
        }
        public void Add(T entity)
        {
            this._list.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                this._list.Add(item);
            }
        }

        public void Delete(int id)
        {
            var entity= this._list.FirstOrDefault(x => x.ID == id);
            if (entity != null)
            {
                this._list.Remove(entity);
            }
        }

        public List<T> GetAll()
        {
            return this._list.ToList();
        }

        public T GetById(int id)
        {
            return this._list.FirstOrDefault(x => x.ID == id);
        }

        public void Update(T entity)
        {
           int i=this._list.IndexOf(entity);
            this._list.RemoveAt(i);
            this._list.Add(entity);
        }
    }
}
