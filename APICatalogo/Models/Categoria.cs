﻿using System.Collections.ObjectModel;

namespace APICatalogo.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }

        public int CategoriaID { get; set; }
        public string? Nome { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
