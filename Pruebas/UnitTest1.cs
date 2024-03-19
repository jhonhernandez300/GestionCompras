using Backend.Controllers;
using LionDev.Models;
using LionDev;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LionDev.Controllers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Pruebas
{
    public class UnitTest1
    {
        //[Fact]
        //public async Task GetByName_ReturnsNotFound_WhenNoProductsFound()
        //{
        //    // Arrange
        //    var mockContext = new Mock<ApplicationDbContext>();
        //    mockContext.Setup(x => x.Productos)
        //               .ReturnsDbSet(new List<Producto>().AsQueryable());

        //    var controller = new ProductoController(null, mockContext.Object);

        //    // Act
        //    var result = await controller.GetByName("NonExistentProduct");

        //    // Assert
        //    Assert.IsType<NotFoundResult>(result.Result);        }

        //[Fact]
        //public async Task GetMasBuscados_ReturnsNotFound_WhenNoProductsFound()
        //{
        //    // Arrange
        //    var mockContext = new Mock<ApplicationDbContext>();
        //    mockContext.Setup(x => x.Productos)
        //               .ReturnsDbSet(new List<Producto>().AsQueryable());

        //    var controller = new ProductoController(null, mockContext.Object);

        //    // Act
        //    var result = await controller.GetGetMasBuscados("Male");

        //    // Assert
        //    Assert.IsType<NotFoundResult>(result.Result);
        //}

        //[Fact]
        //public async Task GetMasBuscados_ReturnsProducts_WhenFound()
        //{
        //    // Arrange
        //    var expectedProducts = new List<Producto>
        //    {
        //        new Producto { Id = 1, Nombre = "Product1", EsDeLosMasBuscados = true, ParaSexo = "Male" },
        //        new Producto { Id = 2, Nombre = "Product2", EsDeLosMasBuscados = true, ParaSexo = "Male" }
        //    };

        //    var mockContext = new Mock<ApplicationDbContext>();
        //    mockContext.Setup(x => x.Productos)
        //               .ReturnsDbSet(expectedProducts.AsQueryable());

        //    var controller = new ProductoController(null, mockContext.Object);

        //    // Act
        //    var result = await controller.GetGetMasBuscados("Male");

        //    // Assert
        //    var okResult = Assert.IsType<OkObjectResult>(result.Result);
        //    var actualProducts = Assert.IsAssignableFrom<IEnumerable<Producto>>(okResult.Value);
        //    Assert.Equal(expectedProducts.Count, actualProducts.Count());
        //}
    }
}