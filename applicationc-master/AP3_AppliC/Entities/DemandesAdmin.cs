using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class DemandesAdmin
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string IdEleve { get; set; } = null!;

    public string Motivation { get; set; } = null!;

    public string? Statut { get; set; }

    public DateTime? DateDemande { get; set; }

    public DateTime? DateTraitement { get; set; }
}
