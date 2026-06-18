using avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.Repositorios
{
        {
        private List<Livros> Livros = new();

    public void Adicionar(Livros L)
    {
        Livros.add(L);
    }

    public List<Livros> ListarTodos()
    {
        return Livros;
    }

    public List<Livros> BuscarPorAutor(string autor)
    {
        return Livros
            .Where(p => p.Autor == autor)
            .ToList();
    }

    public Livro BuscarPorId(int id)
    {
        var livro = Livros.FirstOrDefault(p => p.Id == id);
        return livro ?? throw new LivroNaoEncontradoExceptio($"Id {id} nao encontrado");
    }


}

