using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockTra
{
    public long Id { get; set; }

    /// <summary>
    /// stok fişleri
    /// </summary>
    public int MastId { get; set; }

    public int StockCardId { get; set; }

    public DateTime Date { get; set; }

    public short? FromStorageId { get; set; }

    public short? ToStorageId { get; set; }

    public double Quantity { get; set; }

    public byte UnitType { get; set; }

    public double? UnitPrice { get; set; }

    public double? Vat { get; set; }

    public double? VatRate { get; set; }

    public int? PartyNo { get; set; }

    public DateTime? ExpireDate { get; set; }

    public double? NQuantity { get; set; }

    public double? OQuantity { get; set; }

    public bool? Approve { get; set; }

    public short? ApproveUser { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApproveExp { get; set; }

    public bool Cancel { get; set; }

    public short? CancelUser { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelExp { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public long? TId { get; set; }

    public string? TName { get; set; }

    public virtual Stock Mast { get; set; } = null!;
}
