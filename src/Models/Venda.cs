using System;

namespace PIM_IV_Forms.Models;

public class Venda
{
    public int Id_Venda { get; set; }
    public int Id_Cliente { get; set; }
    public string Nome_Cliente { get; set; }
    public int Id_Produto { get; set; }
    public string Nome_Produto { get; set; }
    public string Descricao_Produto { get; set; }
    public DateTime Data_Venda { get; set; }
    public decimal Valor_Unitario { get; set; }
    public int Quantidade_Vendida { get; set; }
    public decimal Valor_Total { get; set; }
}