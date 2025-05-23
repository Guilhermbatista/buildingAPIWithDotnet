﻿namespace CatalogAPI.Models;

public class Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImgURL { get; set; }
    public float Stock { get; set; }
    public DateTime DateRegister { get; set; }

}
