using System;

namespace PIM_IV_Forms.Models;

public class Compra
{
    public int Id_Compra { get; set; }
    public int Id_Fornecedor { get; set; }
    public string Nome_Fornecedor { get; set; }
    public DateTime Data_Compra { get; set; }
    public int Id_Insumo { get; set; }
    public string Nome_Insumo { get; set; }
    public int Quantidade_Comprada { get; set; }
    public decimal Valor_Unitario { get; set; }
    public decimal Valor_Total { get; set; }
}