using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockKind
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// 1-giriş, 2-çıkış, 3-transfer
    /// </summary>
    public byte IoType { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }
}
