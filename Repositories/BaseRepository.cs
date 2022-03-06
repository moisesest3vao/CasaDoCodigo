using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbset;

        public BaseRepository(ApplicationContext context)
        {
            contexto = context;
            dbset = contexto.Set<T>();
        }

    }
}
