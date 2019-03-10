using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientsControllerTest
    {
        [TestMethod]
        public void Show_ReturnsCorrectView_True()
        {
            ClientsController controller = new ClientsController();
            ActionResult ShowView = controller.Show(1, 1);
            Assert.IsInstanceOfType(ShowView, typeof(ViewResult));
        }
        [TestMethod]
        public void Show_HasCorrrectModelType_ClientList()
        {
          ViewResult ShowView = new ClientsController().Show(1, 1) as ViewResult;
          var result = ShowView.ViewData.Model;
          Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }


    }
  }
