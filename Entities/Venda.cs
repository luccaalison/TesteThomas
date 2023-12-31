﻿namespace Projeto.Loja.Entities
{
    public class Venda : BaseAudityEntity
    {
        public int Id { get; set; }
        public decimal VendaTotal { get; set; }
        public decimal QtdProduto { get; set; }
        public List<VendaProduto> Produtos { get; set; }
    }
}
