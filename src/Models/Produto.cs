using System;

namespace PIM_IV_Forms.Models;

public class Produto
{
    public int Id_Produto { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade_Estoque { get; set; }
    public decimal Preco_Unitario { get; set; }
    public DateTime Data_Validade { get; set; }
}