using System;

namespace PIM_IV_Forms.Models;

public class ClienteFisico
{
    public int Id_Cliente { get; set; }
    public string Nome_Completo { get; set; }
    public string Rg { get; set; }

    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public DateTime Data_De_Nascimento { get; set; }
}
