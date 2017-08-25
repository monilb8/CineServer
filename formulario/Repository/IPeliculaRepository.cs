using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario.Repository
{
    public interface IPeliculaRepository
    {
        Pelicula Create(Pelicula usuario);
        Pelicula Get(long id);
        IQueryable<Pelicula> Get();
        void Put(Pelicula usuario);
        Pelicula Delete(long id);
    }
}
