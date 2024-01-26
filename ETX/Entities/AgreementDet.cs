using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class AgreementDet
{
    public int Id { get; set; }

    public short MastId { get; set; }

    public int StockCardId { get; set; }

    public string? Formula { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public bool? Active { get; set; }

    public virtual Agreement Mast { get; set; } = null!;
}
