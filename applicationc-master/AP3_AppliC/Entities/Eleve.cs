using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class Eleve
{
    public int Ideleve { get; set; }

    public string Nomeleve { get; set; } = null!;

    public string Prenomeleve { get; set; } = null!;

    public string Emaileleve { get; set; } = null!;

    public string? NumEleve { get; set; }

    public string? Motpasseeleve { get; set; }

    public DateOnly Datenaissanceeleve { get; set; }

    public int? Idforfait { get; set; }

    public virtual ICollection<Conduire> Conduires { get; set; } = new List<Conduire>();

    public virtual Forfait? IdforfaitNavigation { get; set; }

    public virtual ICollection<Inscrire> Inscrires { get; set; } = new List<Inscrire>();

    public virtual ICollection<Resultat> Resultats { get; set; } = new List<Resultat>();

    public virtual ICollection<Token> Tokens { get; set; } = new List<Token>();
}
