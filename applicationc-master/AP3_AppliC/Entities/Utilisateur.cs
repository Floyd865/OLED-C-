using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class Utilisateur
{
    public int Iduser { get; set; }

    public string Loginuser { get; set; } = null!;

    public string Mdpuser { get; set; } = null!;
}
