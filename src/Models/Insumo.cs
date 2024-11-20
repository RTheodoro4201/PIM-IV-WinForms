using System;

namespace PIM_IV_Forms.Models;

public class Insumo
{
    public int Id_Insumo { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade_Estoque { get; set; }
    public DateTime Data_Compra { get; set; }
    public DateTime Data_Validade { get; set; }
    public int Id_Fornecedor { get; set; }
    public string Nome_Fornecedor { get; set; }
}