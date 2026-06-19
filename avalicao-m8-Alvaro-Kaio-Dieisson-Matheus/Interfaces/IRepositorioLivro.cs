using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.Interfaces
{
    public interface IRepositorioLivro
    {
        {
        void Adicionar(Livros L);

        List<Livros> ListarTodos();

        List<Livros> BuscarPorAutor(string autor);

        public Livros BuscarPorId(int id);
    }

}
