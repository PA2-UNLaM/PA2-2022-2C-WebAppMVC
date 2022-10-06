using Microsoft.AspNetCore.Mvc;
using Moq;
using PA2_2022_2C_WebAppMVC.Controllers;
using PA2_2022_2C_WebAppMVC.Data;
using PA2_2022_2C_WebAppMVC.Models;

namespace PA2_2022_2C_WebAppMVC_Test
{
    public class ProvinciasControllerTest
    {
        //[Fact]
        //public async Task Index_ReturnsAViewResult_WithAListOfProvinciasAsync()
        //{
        //    // Arrange
        //    var mockRepo = new Mock<IProvinciasRepository>();
        //    mockRepo.Setup(repo => repo.ToListAsync())
        //        .ReturnsAsync(GetTestProvincias());
        //    var controller = new ProvinciasController(mockRepo.Object);

        //    // Act
        //    var result = await controller.Index();

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var model = Assert.IsAssignableFrom<IEnumerable<Provincias>>(
        //        viewResult.ViewData.Model);
        //    //var contentResult = Assert.IsType<ContentResult>(result);
        //    var model1 = Assert.IsType<List<Provincias>>(
        //    viewResult.ViewData.Model);
        //    Assert.Equal("Bs As", model1[0].NomProvincia);
        //    Assert.Equal(2, model.Count());

        //    //model.ToList() 
        //}

        private List<Provincias> GetTestProvincias()
        {
            var provincias = new List<Provincias>();
            provincias.Add(new Provincias()
            {
                Provincia = 1,
                NomProvincia = "Bs As"
            });
            provincias.Add(new Provincias()
            {
                Provincia = 2,
                NomProvincia = "Mendoza"
            });
            return provincias;
        }
    }
}