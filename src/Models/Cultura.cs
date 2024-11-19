using System;

namespace PIM_IV_Forms.Models;

public class Cultura
{
    public int Id_Cultura { get; set; }
    public string Nome { get; set; }
    public DateTime Data_Plantio { get; set; }
    public DateTime Data_Colheita { get; set; }
    public double Area_Plantada { get; set; }
    public int Quantidade_Plantada { get; set; }
    public string Tipo_Solo { get; set; }
    public string Tipo_Irrigacao { get; set; }
    public string Notas { get; set; }
}