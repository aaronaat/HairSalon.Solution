using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistsControllerTest
    {
        [TestMethod]
        public void Show_ReturnsCorrectView_True()
        {
            StylistsController controller = new StylistsController();
            ActionResult ShowView = controller.Show(1);
            Assert.IsInstanceOfType(ShowView, typeof(ViewResult));
        }
        [TestMethod]
        public void Show_HasCorrrectModelType_ClientList()
        {
          ViewResult ShowView = new StylistsController().Show(1) as ViewResult;
          var result = ShowView.ViewData.Model;
          Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }


    }
  }
