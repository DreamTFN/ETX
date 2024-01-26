using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockSubGroup
{
    public short Id { get; set; }

    public short GroupId { get; set; }

    public string Name { get; set; } = null!;

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }
}
