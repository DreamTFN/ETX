using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockOrderTraDet
{
    public long Id { get; set; }

    public long TraId { get; set; }

    public bool Type { get; set; }

    public double Quantity { get; set; }

    public short StorageId { get; set; }

    public DateTime DeliverDate { get; set; }

    public string? DeliverExp { get; set; }

    public string? DelivererName { get; set; }

    public string? RecepientName { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public byte Approve { get; set; }

    public short? ApproveUser { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApproveExp { get; set; }

    public virtual StockOrderTra Tra { get; set; } = null!;
}
