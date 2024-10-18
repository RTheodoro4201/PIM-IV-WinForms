namespace PIM_IV_Forms.Models;

public class Endereco
{
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }
    public string Cep { get; set; }

    public override string ToString()
    {
        string cepFormatado = Cep.Substring(0, 5) + "-" + Cep.Substring(5);

        return $"{Logradouro}, {Numero}, {Complemento}, {Bairro}, {Cidade} - {Uf}, {cepFormatado}";
    }
}