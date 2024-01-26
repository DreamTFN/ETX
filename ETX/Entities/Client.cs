using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class Client
{
    public short Id { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public short InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public bool? Active { get; set; }

    public int SpecialKey { get; set; }

    public string? ResponsibleName { get; set; }

    /// <summary>
    /// 1-kisi, 2-tuzel
    /// </summary>
    public byte? Type { get; set; }

    public string? PersonName { get; set; }

    public string? PersonSurname { get; set; }

    public string? Ssn { get; set; }

    public string? TaxAdministration { get; set; }

    public byte? CityId { get; set; }

    public short? CountyId { get; set; }

    public DateTime? BirthDate { get; set; }

    public bool? Gender { get; set; }

    public short? OccupationId { get; set; }

    public string? Phone2 { get; set; }

    public string? MuhCode { get; set; }

    public string? GroupName { get; set; }

    public string? AdditionalGroupName { get; set; }

    public string? CoordinateX { get; set; }

    public string? CoordinateY { get; set; }
}
