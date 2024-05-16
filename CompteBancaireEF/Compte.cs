using System;
using System.Collections.Generic;

namespace CompteBancaireEF;

public partial class Compte
{
    public long Id { get; set; }

    public string? Proprietaire { get; set; }

    public long? Numero { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
