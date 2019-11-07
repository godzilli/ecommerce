using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CategoriaDAO : iRepository<Categoria>
    {
        private readonly Context _context;
        public CategoriaDAO(Context context)
        {
            _context = context;
        }

        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public bool Cadastrar(Categoria objeto)
        {
            if(BuscarPorNome(objeto) == null)
            {
                _context.Categorias.Add(objeto);
                _context.SaveChanges();
                return false;
            }
            return false;
        }

        public List<Categoria> ListarTodos() => _context.Categorias.ToList();
        
        public Categoria BuscarPorNome(Categoria categoria)
        {
            return _context.Categorias.FirstOrDefault(x => x.Nome.Equals(categoria.Nome));
        }
    }
}
