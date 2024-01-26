using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class UserPersonCor
{
    public short UserId { get; set; }

    public short PersonId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }
}
