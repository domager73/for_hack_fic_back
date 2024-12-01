using System;
using System.Collections.Generic;

namespace for_hack_fic.Db.Models;

public partial class Product
{
    public int Id { get; set; }

    public string BarcodeEan128 { get; set; } = null!;

    public string TypeSign { get; set; } = null!;

    public string Model { get; set; } = null!;

    public decimal RetailPrice { get; set; }

    public string SupplyNumber { get; set; } = null!;

    public string NameRu { get; set; } = null!;

    public string DomesticSize { get; set; } = null!;

    public string ManufacturerSize { get; set; } = null!;

    public string CompositionRu { get; set; } = null!;

    public string CountryOfOrigin { get; set; } = null!;

    public string ManufactureDate { get; set; } = null!;

    public string ImporterRf { get; set; } = null!;

    public string ManufacturerName { get; set; } = null!;

    public string ProducerName { get; set; } = null!;

    public string ProducerAddress { get; set; } = null!;

    public string BarcodeEan13 { get; set; } = null!;
}
