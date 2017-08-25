using formulario.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulario.Servicios
{
    public class EntradaService: IEntradaService
    {
        private IEntradaRepository entradaRepository;
        public EntradaService(IEntradaRepository _entradaRepository)
        {
            this.entradaRepository = _entradaRepository;
        }

        public Entrada Get(long id)
        {
            return entradaRepository.Get(id);
        }

        public IQueryable<Entrada> Get()
        {
            return entradaRepository.Get();
        }

        public Entrada Create(Entrada entrada)
        {
            return entradaRepository.Create(entrada);
        }

        public void Put(Entrada entrada)
        {
            entradaRepository.Put(entrada);
        }

        public Entrada Delete(long id)
        {
            return entradaRepository.Delete(id);
        }
    }
}