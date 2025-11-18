using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class DemandeReinitialisation
{
    public int IdReset { get; set; }

    public string EmailReset { get; set; } = null!;

    public string TokenReset { get; set; } = null!;

    public DateTime ExpireDans { get; set; }
}
