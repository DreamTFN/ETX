using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class Storage
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// 1-ana depo, 0 - tali depo
    /// </summary>
    public bool Type { get; set; }

    public short? RelatedStorageId { get; set; }

    public bool? Active { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }
}
