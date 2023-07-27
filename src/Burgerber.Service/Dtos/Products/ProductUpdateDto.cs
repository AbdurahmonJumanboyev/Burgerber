﻿using Microsoft.AspNetCore.Http;

namespace Burgerber.Service.Dtos.Products;

public class ProductUpdateDto
{
    public long CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;

    public IFormFile? Image { get; set; }

    public double UnitPrice { get; set; }

    public string Description { get; set; } = string.Empty;
}
