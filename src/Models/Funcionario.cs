using System;

namespace PIM_IV_Forms.Models;

public class Funcionario
{
    public int Id_Funcionario { get; set; }
    public string Nome_Completo { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public string Cargo { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public decimal Salario { get; set; }
    public DateTime Data_Admissao { get; set; }
}