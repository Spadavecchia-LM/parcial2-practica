using System;
using System.Collections.Generic;

namespace practicaParcial2.EF;

public partial class User
{
    public long UserId { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
