using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class Categorie
{
    public int Idcategorie { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
