using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockTemplateDet
{
    public short MastId { get; set; }

    public int StockCardId { get; set; }

    public double Quantity { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public virtual StockTemplate Mast { get; set; } = null!;
}
