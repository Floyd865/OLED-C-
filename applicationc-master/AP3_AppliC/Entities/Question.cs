using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class Question
{
    public int Idquestion { get; set; }

    public string Libellequestion { get; set; } = null!;

    public string Imagequestion { get; set; } = null!;

    public int? Idcategorie { get; set; }

    public virtual Categorie? IdcategorieNavigation { get; set; }

    public virtual ICollection<Reponse> Reponses { get; set; } = new List<Reponse>();
}
