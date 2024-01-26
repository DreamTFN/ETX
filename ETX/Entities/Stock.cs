using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class Stock
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Date { get; set; }

    public byte KindId { get; set; }

    public short? ClientId { get; set; }

    public short? FromStorageId { get; set; }

    public short? ToStorageId { get; set; }

    public string? Exp { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public long? TId { get; set; }

    public string? TName { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public short? BillInsertUser { get; set; }

    public DateTime? BillInsertDate { get; set; }

    public virtual ICollection<StockTra> StockTras { get; set; } = new List<StockTra>();
}
