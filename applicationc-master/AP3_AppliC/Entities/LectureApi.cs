using System;
using System.Collections.Generic;

namespace AP3_AppliC.Entities;

public partial class LectureApi
{
    public int Idlecture { get; set; }

    public string Emaillecture { get; set; } = null!;

    public string Mdplecture { get; set; } = null!;

    public DateTime? Datecreation { get; set; }
}
