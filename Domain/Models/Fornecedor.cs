﻿namespace Domain.Models
{
    public class Fornecedor : Entidade<int>
    {
        protected Fornecedor() { }
        public void AtualizarDados(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public int Codigo { get; private set; }
        public string Nome { get; private set; }

    }
}
