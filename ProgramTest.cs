using System;
using System.Collections.Generic;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void GetProduct_ReturnsProduct_WhenIdExists()
    {
        // Arrange
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1" },
            new Product { Id = 2, Name = "Product 2" },
            new Product { Id = 3, Name = "Product 3" }
        };
        int id = 2;

        // Act
        Product? result = Program.GetProduct(products, id);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Product 2", result.Name);
    }

    [Fact]
    public void GetProduct_ReturnsNull_WhenIdDoesNotExist()
    {
        // Arrange
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1" },
            new Product { Id = 2, Name = "Product 2" },
            new Product { Id = 3, Name = "Product 3" }
        };
        int id = 4;

        // Act
        Product? result = Program.GetProduct(products, id);

        // Assert
        Assert.Null(result);
    }
}