using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Core.Entities;
using System.Data.Entity;
using System.Linq;

namespace DevFramework.Northwind.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<T> _entites;

        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual IDbSet<T> Entities
        {
            get { return _entites ?? (_entites = _context.Set<T>()); }
        }
    }
}
