using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class StockCard
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    /// <summary>
    /// 1 stok 0 işlem
    /// </summary>
    public bool KindId { get; set; }

    public short? TypeId { get; set; }

    public short? GroupId { get; set; }

    public short? SubGroupId { get; set; }

    public byte? UnitId { get; set; }

    public short? BrandId { get; set; }

    public string? SeriesNo { get; set; }

    public string? Barcode { get; set; }

    public byte? ConsumptionRateId { get; set; }

    public string? Exp { get; set; }

    public short Piece { get; set; }

    public decimal? Lt { get; set; }

    public decimal? Kg { get; set; }

    public decimal? Volume { get; set; }

    public double? UnitPrice { get; set; }

    public double? VatRate { get; set; }

    public bool VatIncluded { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public bool? Active { get; set; }
}
