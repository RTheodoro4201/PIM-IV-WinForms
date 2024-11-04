using System;

namespace PIM_IV_Forms.Models;

public class Fornecedor
{
    public int Id_Fornecedor { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Endereco { get; set; }
    public string Tipo { get; set; }
    public DateTime Data_Inicial { get; set; }
}