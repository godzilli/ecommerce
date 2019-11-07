using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class UsuarioDAO : iRepository<Usuario>
    {
        private readonly Context _context;
        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioDAO(Context context)
        {
            _context = context;
        }

        public bool Cadastrar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorEmail(Usuario u)
        {
            return _context.Usuarios.FirstOrDefault(x => x.email.Equals(u.email));
        }

        public List<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
