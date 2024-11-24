using System;
using System.Windows.Forms;

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

    public static Endereco ToEndereco(string endereco)
    {
        try
        {
            var enderecoSeparado = endereco.Split(',');

            var enderecoFormatado = new Endereco
            {
                Logradouro = enderecoSeparado[0],
                Numero = enderecoSeparado[1],
                Complemento = enderecoSeparado[2],
                Bairro = enderecoSeparado[3],
                Cidade = enderecoSeparado[4],
                Uf = enderecoSeparado[5],
                Cep = enderecoSeparado[6]
            };

            return enderecoFormatado;
        }
        catch (Exception e)
        {
            MessageBox.Show("Ocorreu um erro ao tentar converter o endereço!\n" + e.Message);
            throw;
        }
    }

    public override string ToString()
    {
        return $"{Logradouro}, {Numero}, {Complemento}, {Bairro}, {Cidade}, {Uf}, {Cep}";
    }
}