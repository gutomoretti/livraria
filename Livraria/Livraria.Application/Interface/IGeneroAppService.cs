using Livraria.Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.Interface
{
    public interface IGeneroAppService : IDisposable
    {
        void ListarGeneros();
        void Cadastrar(Genero genero);
        void Editar(Genero genero);
        void Excluir(Genero genero);
    }
}
