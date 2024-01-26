using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class Agreement
{
    public short Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<AgreementDet> AgreementDets { get; set; } = new List<AgreementDet>();
}
