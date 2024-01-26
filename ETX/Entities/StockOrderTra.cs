using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockOrderTra
{
    public long Id { get; set; }

    public int MastId { get; set; }

    public int StockCardId { get; set; }

    public double Quantity { get; set; }

    public double? OrjUnitPrice { get; set; }

    public double? UnitPrice { get; set; }

    public double? TotalPrice { get; set; }

    public double? TotalVat { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public bool Cancel { get; set; }

    public short? CancelUser { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelExp { get; set; }

    public virtual StockOrder Mast { get; set; } = null!;

    public virtual ICollection<StockOrderTraDet> StockOrderTraDets { get; set; } = new List<StockOrderTraDet>();
}
