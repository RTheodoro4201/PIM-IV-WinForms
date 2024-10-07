using System;

namespace PIM_IV_Forms.Models
{
    public class Compra
    {
        public int Id { get; set; }

        public int IngredienteId { get; set; }

        public string? IngredienteNome { get; set; }

        public decimal Quantidade { get; set; }

        public decimal Preco { get; set; }

        public DateTime Data { get; set; }
    }
}