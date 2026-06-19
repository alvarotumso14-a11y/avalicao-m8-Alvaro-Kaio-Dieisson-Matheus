using avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.Repositorios
{
    
    public List<Livro> Livros = new();

    public void Adicionar(Livro L)
    {
        Livros.add(L);
    }

    public List<Livro> ListarTodos()
    {
        return Livro;
    }

    public List<Livro> BuscarPorAutor(string autor)
    {
        return Livro
            .Where(p => p.Autor == autor)
            .ToList();
    }

    public Livro BuscarPorId(int id)
    {
        var livro = Livro.FirstOrDefault(p => p.Id == id);
        return livro ?? throw new LivroNaoEncontradoExceptio($"Id {id} nao encontrado");
    }


}

