using System;

namespace PIM_IV_Forms.Models;

public class ClienteFisico
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Rg { get; set; }

    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }
    public DateTime DataNascimento { get; set; }
}
