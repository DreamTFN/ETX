using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETX.Entities;

public partial class StockOrder
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short? KindId { get; set; }

    public short ClientId { get; set; }

    public DateTime Date { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Exp { get; set; }

    public short? PlasiyerPersonId { get; set; }

    public short InsertUser { get; set; }

    public DateTime? InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public byte Approve { get; set; }

    public short? ApproveUser { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApproveExp { get; set; }

    public bool Block { get; set; }

    public short? BlockUser { get; set; }

    public DateTime? BlockDate { get; set; }

    public string? BlockExp { get; set; }

    public byte? PayType { get; set; }

    public short? PayPeriod { get; set; }

    public bool Transfer { get; set; }

    public short? TransferUser { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? TransferFisNo { get; set; }

    public string? TransferErr { get; set; }

    public short? RequestStorageId { get; set; }

    public short? HallId { get; set; }

    public short? AgreementId { get; set; }

    public int? AttendeeCount { get; set; }

    public virtual ICollection<StockOrderTra> StockOrderTras { get; set; } = new List<StockOrderTra>();
}
