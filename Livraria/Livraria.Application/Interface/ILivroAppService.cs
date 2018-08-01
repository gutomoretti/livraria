using Livraria.Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.Interface
{
    public interface ILivroAppService : IDisposable
    {
        void ListarLivros();
        void Cadastrar(Livro livro);
        void Editar(Livro livro);
        void Excluir(Livro livro);
    }
}
