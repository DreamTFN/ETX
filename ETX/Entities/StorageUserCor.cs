using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StorageUserCor
{
    public int Id { get; set; }

    public short StorageId { get; set; }

    public short UserId { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }
}
