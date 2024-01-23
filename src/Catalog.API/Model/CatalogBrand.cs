﻿using System.ComponentModel.DataAnnotations;

namespace eShop.Catalog.API.Model;

public class CatalogBrand
{
    public int Id { get; set; }

    [Required]
    public required string Brand { get; set; }
}
