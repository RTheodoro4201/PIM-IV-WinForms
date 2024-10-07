using System;

namespace PIM_IV_Forms.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; }
    public string Funcao { get; set; }
    public string Endereco { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string Telefone { get; set; }
    public string Salario { get; set; }
    public string AgenciaBancaria { get; set; }
    public string ContaBancaria { get; set; }
    public DateTime DataNascimento { get; set; }
}