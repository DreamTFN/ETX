﻿using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockConsumptionRate
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }
}
