﻿using System;
using System.Collections.Generic;

namespace APIMap.Models.Entities;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
