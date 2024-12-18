﻿using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public interface IInsumoRepository : IRepository<Insumo>
{
    Task UpdateEstoque(Insumo insumo);
}