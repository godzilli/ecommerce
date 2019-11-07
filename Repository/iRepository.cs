using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    interface iRepository<T>
    {
        bool Cadastrar(T objeto);
        T BuscarPorId(int id);
        List<T>ListarTodos();
    }
}
