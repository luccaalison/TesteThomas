﻿using Projeto.Loja.Entities;


namespace Projeto.Loja.Models
{
    public class VendasCreateModel 
    {
        public decimal VendaTotal { get; set; }
        public int QtdProduto { get; set; }
        public List<int> items { get; set; }
    }

    public class ProdutoVendaCreateModel {
        public int Id { get; set; }
        public int Qtde { get; set; }
    }
}
